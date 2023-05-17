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

namespace BusTicketApplication
{
    public partial class TicketCancel : Form
    {
        public TicketCancel()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FirstApp;Integrated Security=True");
        SqlCommand cmd;
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            conn.Open();
            string secmeSorgusu = "SELECT * from Bilet where seat_no=@seatno and journey_id=@journeyid";
            cmd = new SqlCommand(secmeSorgusu, conn);
            cmd.Parameters.AddWithValue("@seatno", textBoxSeatNo.Text);
            cmd.Parameters.AddWithValue("@journeyid", textBoxJourneyId.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                string silmeSorgusu1 = "DELETE from Bilet where seat_no=@seatno and journey_id=@journeyid";
                SqlCommand cmd3 = new SqlCommand(silmeSorgusu1, conn);
                cmd3.Parameters.AddWithValue("@seatno", textBoxSeatNo.Text);
                cmd3.Parameters.AddWithValue("@journeyid", textBoxJourneyId.Text);
                cmd3.ExecuteNonQuery();


                MessageBox.Show("Ticket Canceled.");

                dr.Close();
            }
            else
                MessageBox.Show("Ticket Not Found.");

            conn.Close();
            change();
        }
        private void change()
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
