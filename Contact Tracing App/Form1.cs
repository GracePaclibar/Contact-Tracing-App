using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class ContactTracing : Form
    {
        public ContactTracing()
        {
            InitializeComponent();
            if (!Directory.Exists(@"C:\Users\Public\Documents\Contact Tracing Data"))
            {
                string Location = @"C:\Users\Public\Documents";
                string Path = System.IO.Path.Combine(Location, "Contact Tracing Data");
                System.IO.Directory.CreateDirectory(Path);
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            string LastName = txtBoxLastName.Text;
            string FirstName = txtBoxFirstName.Text;
            StreamWriter outputFile;
            outputFile = File.AppendText(@"C:\Users\Public\Documents\Contact Tracing Data\" + LastName + "_" + FirstName + ".txt");
            outputFile.WriteLine("Personal Information:");
            outputFile.WriteLine("First Name:\t" + txtBoxFirstName.Text);
            outputFile.WriteLine("Middle Name:\t" + txtBoxMidName.Text);
            outputFile.WriteLine("Last Name:\t" + txtBoxLastName.Text);
            outputFile.WriteLine("Address:\t" + txtBoxAddress.Text);
            outputFile.WriteLine("Age:\t\t" + txtBoxAge.Text);
            outputFile.WriteLine("Sex:\t\t" + txtBoxSex.Text);
            outputFile.WriteLine("Date:\t\t" + txtBoxDate.Text);
            outputFile.WriteLine("Contact Number:\t" + txtBoxContactNum.Text);
            outputFile.WriteLine("Destination:\t" + txtBoxDestination.Text);
            outputFile.WriteLine(" ");
            outputFile.WriteLine("Symptoms:");
            
            foreach(Control symptom in panel1.Controls)
            {
                if((symptom is CheckBox) && ((CheckBox)symptom).Checked)
                {
                    outputFile.WriteLine("\t\t" + symptom.Text);
                }
            }
            outputFile.Close();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBoxFirstName.Clear();
            txtBoxMidName.Clear();
            txtBoxLastName.Clear();
            txtBoxAddress.Clear();
            txtBoxAge.Clear();
            txtBoxSex.Clear();
            txtBoxDate.Clear();
            txtBoxContactNum.Clear();
            txtBoxDestination.Clear();
            chkBoxFever.Checked = false;
            chkBoxCough.Checked = false;
            chkBoxColds.Checked = false;
            chkBoxSoreThroat.Checked = false;
            chkBoxDifInBreathing.Checked = false;
            chkBoxDiarrhea.Checked = false;
        }

        Form2 secondForm = new Form2();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Public\Documents\Contact Tracing Data";
                openFileDialog.DefaultExt = "txt";
                filePath = openFileDialog.FileName;
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    secondForm.Show();
                }
            }
        }
    }
}
