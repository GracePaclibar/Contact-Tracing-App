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
            outputFile.WriteLine("==============================");
            outputFile.WriteLine("First Name:");
            outputFile.WriteLine(txtBoxFirstName.Text);
            outputFile.WriteLine("Middle Name:");
            outputFile.WriteLine(txtBoxMidName.Text);
            outputFile.WriteLine("");
            outputFile.WriteLine("Last Name:");
            outputFile.WriteLine(txtBoxLastName.Text);
            outputFile.WriteLine("");
            outputFile.WriteLine("Address:");
            outputFile.WriteLine(txtBoxAddress.Text);
            outputFile.WriteLine("");
            outputFile.WriteLine("Age:");
            outputFile.WriteLine(txtBoxAge.Text);
            outputFile.WriteLine("");
            outputFile.WriteLine("Sex:");
            outputFile.WriteLine(txtBoxSex.Text);
            outputFile.WriteLine("");
            outputFile.WriteLine("Date:");
            outputFile.WriteLine(txtBoxDate.Text);
            outputFile.WriteLine("");
            outputFile.WriteLine("Contact Number:");
            outputFile.WriteLine(txtBoxContactNum.Text);
            outputFile.WriteLine("");
            outputFile.WriteLine("Destination:");
            outputFile.WriteLine(txtBoxDestination.Text);
            outputFile.WriteLine("==============================");
            outputFile.WriteLine("Symptoms:");
            
            foreach(Control symptom in panel1.Controls)
            {
                if((symptom is CheckBox) && ((CheckBox)symptom).Checked)
                {
                    outputFile.WriteLine(symptom.Text);
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

        public static string FirstName = "";

        Form2 secondForm = new Form2();

        private void ValueForFirstName(string text)
        {
            FirstName = text;
        }

        public void btnOpen_Click(object sender, EventArgs e)
        {

            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Public\Documents\Contact Tracing Data";
                openFileDialog.DefaultExt = "txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader inputFile;
                    inputFile = File.OpenText(openFileDialog.FileName);

                    if (Form2.FirstName == "")
                    {
                        int lineNumber = 5;
                        for (int i = 1; i < lineNumber; i++)
                        {
                            ValueForFirstName(inputFile.ReadLine());
                        }
                    }

                 secondForm.Show();
                }
            }
        }

    }
}
