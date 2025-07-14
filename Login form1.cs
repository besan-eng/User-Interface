using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string connectionString = "Server=LAPTOP-NMRQ1SGD;Database=project prog3;Trusted_Connection=True;";

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

            string username = Username_textBox.Text.Trim();
            string password = Password_textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage2.Text = "Please fill in all the fields";
                return;
            }
            // connection line
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM users  WHERE username = @username AND password = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            
                            Form2 nextForm = new Form2(); 
                            this.Hide(); 
                            nextForm.Show();
                        }
                        else
                        {
                            lblMessage2.Text = "Invalid username or password.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            Sign_up Register = new Sign_up();

            this.Hide();
            Register.Show();
        }



        private void quit_button_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Username_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void View_password_Click(object sender, EventArgs e)
        {
            Password_textBox.UseSystemPasswordChar = !Password_textBox.UseSystemPasswordChar;
            /* if (Password_textBox.UseSystemPasswordChar)
             {
                 View_password.Text = "Show";
             }
             else
             {
                 View_password.Text = "Hide";
             }*/
        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}