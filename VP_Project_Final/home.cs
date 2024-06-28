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
using System.Configuration;
using System.Runtime.Remoting.Contexts;

namespace VP_Project_Final
{ 



    public partial class home : Form
    {
        int price = 0;
        int tax = 1000;

        public home()
    { 
            InitializeComponent();
        /* try
         {
             using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Abbas Khan\Documents\car_Records.mdf; Integrated Security=True; Connect Timeout=30; Encrypt=True"))
             {
                 con.Open();

                 string query = "INSERT INTO car_records (make, model, varient, name, chasis) VALUES (@Make, @Model, @Varient, @Name, @Chasis)";
                 SqlCommand cmd = new SqlCommand(query, con);

                 // Set parameter values
                 cmd.Parameters.AddWithValue("@Make", "honda");
                 cmd.Parameters.AddWithValue("@Model", "city");
                 cmd.Parameters.AddWithValue("@Varient", "1.5 aspire");
                 cmd.Parameters.AddWithValue("@Name", "city");
                 cmd.Parameters.AddWithValue("@Chasis", "123456789");

                 int rowsAffected = cmd.ExecuteNonQuery();
                 if (rowsAffected > 0)
                 {
                     MessageBox.Show("Record inserted successfully");
                 }
                 else
                 {
                     MessageBox.Show("Record not inserted");
                 }
             }
         }
         catch (SqlException ex)
         {
             MessageBox.Show("An error occurred: " + ex.Message);
         }*/

     }
    
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            home.ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String selection="";
            
            
            if (comboBox1.SelectedItem!=null)
            {
                selection = comboBox1.SelectedItem.ToString();
                price = 1000000;
            }
            else if (comboBox2.SelectedItem != null)
            {
                selection = comboBox2.SelectedItem.ToString();
                price = 2000000;
            }
            else if (comboBox3.SelectedItem != null)
            {
                selection = comboBox3.SelectedItem.ToString();
                price = 3000000;
            }
           else  if (comboBox4.SelectedItem != null)
            {
                selection = comboBox4.SelectedItem.ToString();
                price = 4000000;
            }
            richTextBox1.AppendText("\t\t" + "Welcome to Drive Hub" + "\n");
            richTextBox1.AppendText(("\t" + "name   :" )+ textBox_username.Text + ("\n"));
            richTextBox1.AppendText("\t" + "user id   :" + textBox_userid.Text + "\n");
            richTextBox1.AppendText("\t" + "Your selected car is: " + selection + "\n");
           6rof the car is " + textBox_varient.Text + "\n");
            richTextBox1.AppendText("\t" + "chasis number of the car is " + textBox_chasis.Text + "\n");
            richTextBox1.AppendText("\t" + "price of the car is " + price + "\n");
            richTextBox1.AppendText("\t" + "the tax on the vehicle will be " +tax + "\n");
            richTextBox1.AppendText("\t" + "Total amount to be paid is " + (price + tax) + "\n");
            richTextBox1.AppendText("\t" + "Thank you for choosing Drive Hub" + "\n");
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            home.ActiveForm.Close();
            checkout checkout = new checkout(price,tax);
            checkout.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home.ActiveForm.Close();
            add_new checkout = new add_new();
            checkout.ShowDialog();
        }
        
    }
} 

