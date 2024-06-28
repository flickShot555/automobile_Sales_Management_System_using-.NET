using System;
using System.IO;
using System.Windows.Forms;

namespace VP_Project_Final
{
    public partial class add_new : Form
    {
        public add_new()
        {
            InitializeComponent();
        }
//extra
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //EXTRA
        private void add_new_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string make, model, varient, name, chasis;
            make=textBox_MAKE.Text;
            model = textBox_MODEL.Text;
            varient = textBox_VARIENT.Text;
            name = textBox_NAME.Text;
            chasis = textBox_CHASISNUM.Text;
            if (make == "" || model == "" || varient == "" || name == "" || chasis == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                SaveToFile($"Make: {make}\nModel: {model}\nVarient: {varient}\nName: {name}\nChasis: {chasis}");
            }

        }
        private void SaveToFile(string content)
        {
            string filePath = @"C:\\Users\\Abbas Khan\\Documents\\text_file_2_porject.txt";

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
    }
}
