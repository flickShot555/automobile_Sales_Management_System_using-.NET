using System;
using System.Drawing;
using System.Windows.Forms;

namespace VP_Project_Final
{
    public partial class Form1 : Form
    {
        private const string PLACEHOLDER_TEXT = "Enter here";
        public Form1()
        {
            InitializeComponent();
            usernametextbox.Text = PLACEHOLDER_TEXT; // Set initial placeholder text
            usernametextbox.ForeColor = Color.Gray; // Set placeholder text color
        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {
            if (usernametextbox.Text == PLACEHOLDER_TEXT)
            {
                // Clear the textbox and change its text color
                //usernametextbox.Text = "";
                usernametextbox.ForeColor = SystemColors.WindowText; // Restore default text color
            }

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(usernametextbox.Text == "admin" && textBoxpass.Text == "admin")
            {
                
                this.Hide();
                home f2 = new home();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
