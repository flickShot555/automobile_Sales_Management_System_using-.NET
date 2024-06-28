using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project_Final
{
    
    public partial class checkout : Form
    {

        public int a, b;
        public checkout(int c, int d)
        {
            InitializeComponent();
            textBox4.Enabled = false;
            a = c;
            b = d;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string make, model, varient, name, chasis;
            make = textBox_MAKE.Text;
            model = textBox_MODEL.Text;
            varient = textBox_VARIENT.Text;
            name = textBox_NAME.Text;
            chasis = textBox_CHASISNUM.Text;
            string uname, id, adress, card;
            uname=textBox1.Text;
            id = textBox3.Text;
            adress = richTextBox1.Text;
            string receipt = $"Receipt\n" +
                         $"--------------------------------\n" +
                         $"Vehicle Information:\n" +
                         $"Make: {make}\n" +
                         $"Model: {model}\n" +
                         $"Varient: {varient}\n" +
                         $"Price: {a}\n" +
                         $"Tax: {b}\n" +

                         $"Name: {name}\n" +
                         $"Chasis Number: {chasis}\n\n" +
                         $"Customer Information:\n" +
                         $"Name: {uname}\n" +
                         $"ID: {id}\n" +
                         $"Address: {adress}\n" +
                         $"--------------------------------";

            SaveToFile(receipt);
        }

        private void SaveToFile(string content)
        {
            string filePath = @"C:\\Users\\Abbas Khan\\Documents\\text_file_porject.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(content);
                }

                MessageBox.Show("Receipt saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if( radioButton1.Checked)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
            }
        }
    }
}
