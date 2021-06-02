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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtBoxFirstName.Text = ContactTracing.FirstName;
            txtBoxMidName.Text = ContactTracing.MidName;
            txtBoxLastName.Text = ContactTracing.LastName;
            txtBoxAddress.Text = ContactTracing.Address;
            txtBoxAge.Text = ContactTracing.Age;
            txtBoxGender.Text = ContactTracing.Gender;
            txtBoxDate.Text = ContactTracing.Date;
            txtBoxContactNum.Text = ContactTracing.ContactNumber;
            txtBoxDestination.Text = ContactTracing.Destination;
            txtBoxSymptom1.Text = ContactTracing.Symptom1;
            txtBoxSymptom2.Text = ContactTracing.Symptom2;
            txtBoxSymptom3.Text = ContactTracing.Symptom3;
            txtBoxSymptom4.Text = ContactTracing.Symptom4;
            txtBoxSymptom5.Text = ContactTracing.Symptom5;
            txtBoxSymptom6.Text = ContactTracing.Symptom6;

        }
    }
}
