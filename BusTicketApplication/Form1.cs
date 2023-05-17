using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace BusTicketApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelControl();
            groupBoxBus.Enabled = false;
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FirstApp;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader read;
        public int seat_number;
        public int journey_id;
        public int passenger_id;
        public int sameSeatJourney;
        public bool isJourneySelected = false;
        public bool isSameSeatNumberSelected = false;
        //for cancel ticket
        public static string firstBusMaleNumber = "";
        public static string firstBusFemaleNumber = "";
        public static string secondBusMaleNumber = "";
        public static string secondBusFemaleNumber = "";
        public static string thirdBusMaleNumber = "";
        public static string thirdBusFemaleNumber = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'firstAppDataSet.Sefer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seferTableAdapter.Fill(this.firstAppDataSet.Sefer);
            
        }

        //formu açan kişi üye mi değil mi kontrol eder
        private void panelControl()
        {
            if (Login.id != 0)
            {
                panelRegister.Visible = false;
            }
            else
            {
                panelRegister.Visible = true;
                groupBoxDataGrid.Enabled = false;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            // koltuk veya sefer'in seçilip seçilmediğini kontrol eder
            if (radioBtnSelectedControl() && isJourneySelected)
            {
                //kayıtlı kullanıcı satın al butonuna bastıktan sonra yolcu tablosuna eklenir
                if (Login.id != 0)
                {
                    insertUserYolcu();
                }

                insertTicket();
                controlBeforeSeatJourney();
            }
            else
                MessageBox.Show("Please select seat or journey!");
        }



        // kayıtlı olmayan kişiyi yolcu tablosuna ekler
        private void insertYolcu()
        {
            try
            {
                conn.Open();
                // Yolcu tablosuna kayıt ekler
                cmd = new SqlCommand("insert into Yolcu (name,surname,mail,gender) values(@name,@surname,@mail,@gender)", conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                if (radioButtonMale.Checked)
                    cmd.Parameters.AddWithValue("@gender", radioButtonMale.Text);
                else
                    cmd.Parameters.AddWithValue("@gender", radioButtonFemale.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Created.");
                groupBoxDataGrid.Enabled = true;
                findLastPassengerId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: ", ex.ToString());
            }
        }

        //kullanici tablosundan kayıtlı kullanıcıyı yolcu tablosuna ekler
        private void insertUserYolcu()
        {
            try
            {
                conn.Open();
                panelRegister.Visible = false;
                //kullanici tablosundan kayıtlı kullanıcının bilgileri alınıyor
                cmd = new SqlCommand("select * from Kullanici where user_id = " + Login.id + "", conn);
                read = cmd.ExecuteReader();
                ArrayList arrl = new ArrayList();
                while (read.Read())
                {
                    arrl.Add(read["name"].ToString());
                    arrl.Add(read["surname"].ToString());
                    arrl.Add(read["mail"].ToString());
                    arrl.Add(read["gender"].ToString());
                }
                read.Close();
                // Yolcu tablosuna kayıt ekler
                cmd = new SqlCommand("insert into Yolcu (name,surname,mail,gender) values(@name,@surname,@mail,@gender)", conn);
                cmd.Parameters.AddWithValue("@name", arrl[0]);
                cmd.Parameters.AddWithValue("@surname", arrl[1]);
                cmd.Parameters.AddWithValue("@mail", arrl[2]);
                cmd.Parameters.AddWithValue("@gender", arrl[3]);
                cmd.ExecuteNonQuery();
                conn.Close();
                findLastPassengerId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // kayıt butonu 
        private void btnSave_Click(object sender, EventArgs e)
        {
            insertYolcu();
        }

        // radio buttonlar arasından seçilen butonu bulma 
        private void radioBtnControl(string gender)
        {
            for (int i = 0; i < groupBoxBus.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)groupBoxBus.Controls[i];
                if (rb.Checked == true)
                {
                    if (gender.ToLower() == "male")
                        rb.BackColor = Color.Cyan;
                    else
                        rb.BackColor = Color.Pink;
                    seat_number = Convert.ToInt32(rb.Text);
                }
            }
        }

        // satın al butonuna basmadan önce koltuk seçimi yapılmış mı kontrol eder
        private bool radioBtnSelectedControl()
        {
            for (int i = 0; i < groupBoxBus.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)groupBoxBus.Controls[i];
                if (rb.Checked == true)
                {
                    return true;
                }
            }
            return false;
        }
        public void findJourneyid(string start, string destination)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from Sefer where departure = '" + start + "' and destination = '" + destination + "'", conn);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    journey_id = Convert.ToInt32(read["journey_id"].ToString());

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //koltuk enable-disable yapar
        private void radioBtnLock()
        {
            ArrayList arrSeat = new ArrayList();
            ArrayList passId = new ArrayList();
            finSeatNumberPassengerIds(ref arrSeat, ref passId);
            radioFillColor(ref arrSeat, ref passId);
        }

        private void radioBtnClear()
        {
            for (int i = 0; i < groupBoxBus.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)groupBoxBus.Controls[i];
                if (rb.Enabled == false || rb.Checked == true)
                {
                    rb.BackColor = Color.LightGray;
                    rb.Enabled = true;
                }
            }
        }

        // hücredeki varıs ve kalkıs yerini alır
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string start = row.Cells[0].Value.ToString();
            string destination = row.Cells[1].Value.ToString();
            findJourneyid(start, destination);
            radioBtnClear();
            radioBtnLock();
            groupBoxBus.Enabled = true;
            //journey seçilmediyse false
            isJourneySelected = true;
        }

        private void findLastPassengerId()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT TOP 1 * FROM Yolcu ORDER BY passenger_id DESC", conn);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    passenger_id = Convert.ToInt32(read["passenger_id"].ToString());
                    radioBtnControl(read["gender"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void insertTicket()
        {
            findLastPassengerId();
            try
            {
                conn.Open();
                // Bilet tablosuna kayıt ekler
                cmd = new SqlCommand("insert into Bilet (passenger_id,journey_id,seat_no) values(" + passenger_id + "," + journey_id + "," + seat_number + ")", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void finSeatNumberPassengerIds(ref ArrayList arrSet, ref ArrayList passId)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("select seat_no,passenger_id from Bilet where journey_id =" + journey_id + "", conn);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    //secilen seferdeki  seçilmiş koltuk numaralarını bulur ve diziye ekler
                    arrSet.Add(Convert.ToInt32(read["seat_no"].ToString()));
                    // secilen seferdeki koltukları alan yolcuların passenger_id lerini alır diziye ekler
                    passId.Add(Convert.ToInt32(read["passenger_id"].ToString()));
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void radioFillColor(ref ArrayList arrSet, ref ArrayList passId)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from Yolcu ", conn);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    for (int j = 0; j < passId.Count; j++)
                    {
                        if (passId[j].ToString() == read["passenger_id"].ToString())
                        {
                            string gender = read["gender"].ToString();
                            for (int i = 0; i < groupBoxBus.Controls.Count; i++)
                            {
                                RadioButton rb = (RadioButton)groupBoxBus.Controls[i];
                                if (rb.Text.ToString() == arrSet[j].ToString())
                                {
                                    if (gender.ToLower() == "male")
                                    {
                                        rb.BackColor = Color.Cyan;
                                        rb.Enabled = false;
                                    }
                                    else
                                    {
                                        rb.BackColor = Color.Pink;
                                        rb.Enabled = false;
                                    }

                                }
                            }
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // yolcu aynı bileti tekrar tekrar almasın diye kontrol
        private void controlBeforeSeatJourney()
        {

            try
            {
                int row_number = 0;
                conn.Open();
                cmd = new SqlCommand("select * from Bilet where journey_id= " + journey_id + " and seat_no=" + seat_number + "", conn);
                read = cmd.ExecuteReader();
                while (read.Read())
                    row_number++;
                conn.Close();
                if (row_number > 1)
                {
                    //tabloya tekrar eklenen bileti siler
                    deletelastTicket();
                    //tabloya tekrar eklenen kayıtlı kullanıcıyı siler
                    deletelastUserPassenger();
                }
                else
                {
                    MessageBox.Show("Buying Succesfully ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // eklenen aynı biletten son ekleneni siler
        private void deletelastTicket()
        {
            try
            {
                conn.Open();
                //delete last record
                cmd = new SqlCommand("DELETE FROM Bilet WHERE  ticket_no = (SELECT Max(ticket_no) FROM Bilet)", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //son kayıtlı yolcuyu siler
        private void deletelastUserPassenger()
        {
            if (Login.id != 0)
            {
                try
                {
                    conn.Open();
                    //delete last record
                    cmd = new SqlCommand("DELETE FROM Yolcu WHERE  passenger_id= (SELECT Max(passenger_id) FROM Yolcu)", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            MessageBox.Show("Already bought this seat, please change seat number!");
        }
        // Ticket cancel
        private void btnTicketCancel_Click_1(object sender, EventArgs e)
        {
            TicketCancel ticketCancel = new TicketCancel();
            ticketCancel.Show();
            this.Hide();
        }

        // Bus info
        private void BtnBusInfo_Click(object sender, EventArgs e)
        {
            InfoBus info = new InfoBus();
            info.Show();
            this.Hide();
        }
        private void buttonShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
