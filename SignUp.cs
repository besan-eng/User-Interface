using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sign_up : Form
    {
        private string connectionString = "Server=LAPTOP-NMRQ1SGD;Database=project prog3;Trusted_Connection=True;";

        public Sign_up()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Username__label_Click(object sender, EventArgs e)
        {

        }

        private void View_password_Click(object sender, EventArgs e)
        {
            Password_textBox.UseSystemPasswordChar = !Password_textBox.UseSystemPasswordChar;
        }

        private void View_password2_Click(object sender, EventArgs e)
        {
            Confirm_Password.UseSystemPasswordChar = !Confirm_Password.UseSystemPasswordChar;
        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_Up_but_Click(object sender, EventArgs e)
        {
            string username = Username_textBox.Text.Trim();
            string password = Password_textBox.Text.Trim();
            string confirmPassword = Confirm_Password.Text.Trim();
            string email = Email_textBox1.Text.Trim();

           
            if (string.IsNullOrEmpty(username)  string.IsNullOrEmpty(password) 
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(confirmPassword))
            {
                lblMessage.Text = "Please fill in all the fields";
                return;
            }

           
            if (password != confirmPassword)
            {
                lblMessage.Text = "Password and Confirm Password do not match";
                return;
            }

            bool success = InsertUser(username, password, email);
            if (success)
            {

                Form1 nextForm = new Form1(); 
                this.Hide(); 
                nextForm.Show(); 
                /* lblMessage.Text = ""; 
                 Username_textBox.Text = "";
                 Password_textBox.Text = "";
                 Confirm_Password.Text = "";
                 Email_textBox1.Text = "";*/
            }
            else
            {
                lblMessage.Text = "An error occurred while saving";
            }
        }

        private void Username_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private bool InsertUser(string username, string password, string email)
        {
            string query = "INSERT INTO users (username, password, email) VALUES (@username, @password, @email)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}