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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string LastName = txtBoxLastName.Text;
            StreamWriter outputFile;
            outputFile = File.AppendText("LastName.txt");
            outputFile.WriteLine("First Name:");
            outputFile.WriteLine(txtBoxFirstName.Text);
            outputFile.WriteLine("Middle Name:");
            outputFile.WriteLine(txtBoxMidName.Text);
            outputFile.WriteLine("Last Name:");
            outputFile.WriteLine(txtBoxLastName.Text);
            outputFile.WriteLine("Address:");
            outputFile.WriteLine(txtBoxAddress.Text);
            outputFile.WriteLine("Age:");
            outputFile.WriteLine(txtBoxAge.Text);
            outputFile.WriteLine("Sex:");
            outputFile.WriteLine(txtBoxSex.Text);
            outputFile.WriteLine("Contact Number:");
            outputFile.WriteLine(txtBoxContactNum.Text);
            outputFile.WriteLine("Destination:");
            outputFile.WriteLine(txtBoxDestination.Text);
            outputFile.WriteLine("Date:");
            outputFile.WriteLine(txtBoxDate.Text);
            outputFile.Close();

        }
    }
}
