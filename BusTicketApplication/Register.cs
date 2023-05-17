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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FirstApp;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader read;
        private void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(comboBoxGender.SelectedItem.ToString()))
                {
                    MessageBox.Show("Please enter your information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }
                conn.Open();
                cmd = new SqlCommand("select * from Kullanici where Username = '" + txtUsername.Text + "'", conn);
                read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    conn.Close();
                    MessageBox.Show(" Username have been used another user please change username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    read.Close();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Kullanici(name,surname,username,password,gender,mail) VALUES (@name,@surname,@username,@password,@gender,@mail)", conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.ToString());
                    cmd.Parameters.AddWithValue("@surname", txtSurname.Text.ToString());
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.ToString());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.ToString());
                    cmd.Parameters.AddWithValue("@gender", comboBoxGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@mail", txtMail.Text.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    changeForm();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeForm()
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtSurname.Focus();
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtUsername.Focus();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                comboBoxGender.Focus();
        }

        private void comboBoxGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtMail.Focus();
        }
        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtMail.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
