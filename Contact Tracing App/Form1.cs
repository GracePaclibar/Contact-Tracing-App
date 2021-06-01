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
            outputFile = File.AppendText(@"C:\Users\Public\Documents\Contact Tracing Data\" + LastName + ".txt");
            outputFile.WriteLine("First Name:\t\t" + txtBoxFirstName.Text);
            outputFile.WriteLine("Middle Name:\t\t" + txtBoxMidName.Text);
            outputFile.WriteLine("Last Name:\t\t" + txtBoxLastName.Text);
            outputFile.WriteLine("Address:\t\t" + txtBoxAddress.Text);
            outputFile.WriteLine("Age:\t\t" + txtBoxAge.Text);
            outputFile.WriteLine("Sex:\t\t" + txtBoxSex.Text);
            outputFile.WriteLine("Contact Number:\t\t" + txtBoxContactNum.Text);
            outputFile.WriteLine("Destination:\t\t" + txtBoxDestination.Text);
            outputFile.WriteLine("Date:\t\t" + txtBoxDate.Text);
            outputFile.Close();

        }
    }
}
