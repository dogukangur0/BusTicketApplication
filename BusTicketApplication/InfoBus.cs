using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace BusTicketApplication
{
    public partial class InfoBus : Form
    {
        public InfoBus()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FirstApp;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader read;
        public int journey_id, maleN = 0, femaleN = 0;
        ArrayList arrPassengerId = new ArrayList();

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); ;
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            maleN = 0; femaleN = 0;
            chart1.Series["Gender"].Points.Clear();
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string start = row.Cells[0].Value.ToString();
            string destination = row.Cells[1].Value.ToString();
            findJourneyid(start, destination);
            findPassengerId();
            setGender();
            findGender(1);
            chartFill();
        }

        private void findJourneyid(string start, string destination)
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
        private void findPassengerId()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from Bilet where journey_id = " + journey_id + "", conn);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    arrPassengerId.Add(Convert.ToInt32(read["passenger_id"].ToString()));
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void findGender(int passenger_id)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from Yolcu where passenger_id = " + passenger_id + "", conn);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    if (read["gender"].ToString().ToLower() == "male")
                        maleN++;
                    else
                        femaleN++;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InfoBus_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'firstAppDataSetInfo.Sefer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seferTableAdapter.Fill(this.firstAppDataSetInfo.Sefer);

        }

        private void setGender()
        {

            for (int i = 0; i < arrPassengerId.Count; i++)
            {
                findGender(Convert.ToInt32(arrPassengerId[i]));
            }
            arrPassengerId.Clear(); //kullandıktan sonra içini boşaltıp yeni passengerları ekliyoruz
        }

        private void chartFill()
        {
            chart1.Series["Gender"].Points.AddXY("Male", maleN);
            chart1.Series["Gender"].Points.AddXY("Female", femaleN);
         
        }
    }
}
