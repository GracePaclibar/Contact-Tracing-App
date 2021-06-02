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
            string MidName = txtBoxMidName.Text;
            string FirstName = txtBoxFirstName.Text;
            if (File.Exists(@"C:\Users\Public\Documents\Contact Tracing Data\" + LastName + "_" + FirstName + "_" + MidName + ".txt"))
            {
                MessageBox.Show("Data Already Exists!");
            }
            else
            {
                StreamWriter outputFile;
                outputFile = File.AppendText(@"C:\Users\Public\Documents\Contact Tracing Data\" + LastName + "_" + FirstName + "_" + MidName + ".txt");
                outputFile.WriteLine("Personal Information:");
                outputFile.WriteLine("==============================");
                outputFile.WriteLine("First Name:");
                outputFile.WriteLine(txtBoxFirstName.Text);
                outputFile.WriteLine("");
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
                outputFile.WriteLine("Gender:");
                outputFile.WriteLine(txtBoxGender.Text);
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

                foreach (Control symptom in panel1.Controls)
                {
                    if ((symptom is CheckBox) && ((CheckBox)symptom).Checked)
                    {
                        outputFile.WriteLine(symptom.Text);
                    }
                }

                outputFile.Close();
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBoxFirstName.Clear();
            txtBoxMidName.Clear();
            txtBoxLastName.Clear();
            txtBoxAddress.Clear();
            txtBoxAge.Clear();
            txtBoxGender.Clear();
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
        public static string MidName = "";
        public static string LastName = "";
        public static string Address = "";
        public static string Age = "";
        public static string Gender = "";
        public static string Date = "";
        public static string ContactNumber = "";
        public static string Destination = "";
        public static string Symptom1 = "";
        public static string Symptom2 = "";
        public static string Symptom3 = "";
        public static string Symptom4 = "";
        public static string Symptom5 = "";
        public static string Symptom6 = "";


        Form2 secondForm = new Form2();

        private void SetFirstName(string text)
        {
            FirstName = text;
        }

        private void SetMidName(string text)
        {
            MidName = text;
        }

        private void SetLastName(string text)
        {
            LastName = text;
        }

        private void SetAddress(string text)
        {
            Address = text;
        }

        private void SetAge(string text)
        {
            Age = text;
        }

        private void SetGender(string text)
        {
            Gender = text;
        }

        private void SetDate(string text)
        {
            Date = text;
        }

        private void SetContactNum(string text)
        {
            ContactNumber = text;
        }

        private void SetDestination(string text)
        {
            Destination = text;
        }

        private void SetSymptom1(string text)
        {
            Symptom1 = text;
        }
        private void SetSymptom2(string text)
        {
            Symptom2 = text;
        }
        private void SetSymptom3(string text)
        {
            Symptom3 = text;
        }
        private void SetSymptom4(string text)
        {
            Symptom4 = text;
        }
        private void SetSymptom5(string text)
        {
            Symptom5 = text;
        }
        private void SetSymptom6(string text)
        {
            Symptom6 = text;
        }

        public void btnOpen_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Public\Documents\Contact Tracing Data";
                openFileDialog.DefaultExt = "txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader inputFile;
                    inputFile = File.OpenText(openFileDialog.FileName);

                    int progress = 0;

                    if (progress < 10)
                    {
                        int lineNumberFirst = 5;
                        for (int i = 1; i < lineNumberFirst; i++)
                        {
                            SetFirstName(inputFile.ReadLine());
                            progress = progress++;
                        }

                        if (progress < 10)
                        {
                            int lineNumberMid = 4;
                            for (int i = 1; i < lineNumberMid; i++)
                            {
                                SetMidName(inputFile.ReadLine());
                                progress = progress++;
                            }

                            if (progress < 10)
                            {
                                int lineNumberLast = 4;
                                for (int i = 1; i < lineNumberLast; i++)
                                {
                                    SetLastName(inputFile.ReadLine());
                                    progress = progress++;
                                }

                                if (progress < 10)
                                {
                                    int lineNumberAddy = 4;
                                    for (int i = 1; i < lineNumberAddy; i++)
                                    {
                                        SetAddress(inputFile.ReadLine());
                                        progress = progress++;
                                    }

                                    if (progress < 10)
                                    {
                                        int lineNumberAge = 4;
                                        for (int i = 1; i < lineNumberAge; i++)
                                        {
                                            SetAge(inputFile.ReadLine());
                                            progress = progress++;
                                        }

                                        if (progress < 10)
                                        {
                                            int lineNumberGender = 4;
                                            for (int i = 1; i < lineNumberGender; i++)
                                            {
                                                SetGender(inputFile.ReadLine());
                                                progress = progress++;
                                            }

                                            if (progress < 10)
                                            {
                                                int lineNumberDate = 4;
                                                for (int i = 1; i < lineNumberDate; i++)
                                                {
                                                    SetDate(inputFile.ReadLine());
                                                    progress = progress++;
                                                }

                                                if (progress < 10)
                                                {
                                                    int lineNumberContactNum = 4;
                                                    for (int i = 1; i < lineNumberContactNum; i++)
                                                    {
                                                        SetContactNum(inputFile.ReadLine());
                                                        progress = progress++;
                                                    }

                                                    if (progress < 10)
                                                    {
                                                        int lineNumberDestination = 4;
                                                        for (int i = 1; i < lineNumberDestination; i++)
                                                        {
                                                            SetDestination(inputFile.ReadLine());
                                                            progress = progress++;
                                                        }

                                                        int symptomProgress = 0;

                                                        if (symptomProgress < 7)
                                                        {
                                                            int lineNumberSymptom1 = 4;
                                                            for (int i = 1; i < lineNumberSymptom1; i++)
                                                            {
                                                                SetSymptom1(inputFile.ReadLine());
                                                                symptomProgress++;
                                                            }

                                                            if (symptomProgress < 7)
                                                            {
                                                                int lineNumberSymptom2 = 2;
                                                                for (int i = 1; i < lineNumberSymptom2; i++)
                                                                {
                                                                    SetSymptom2(inputFile.ReadLine());
                                                                    symptomProgress++;
                                                                }

                                                                if (symptomProgress < 7)
                                                                {
                                                                    int lineNumberSymptom3 = 2;
                                                                    for (int i = 1; i < lineNumberSymptom3; i++)
                                                                    {
                                                                        SetSymptom3(inputFile.ReadLine());
                                                                        symptomProgress++;
                                                                    }

                                                                    if (symptomProgress < 7)
                                                                    {
                                                                        int lineNumberSymptom4 = 2;
                                                                        for (int i = 1; i < lineNumberSymptom4; i++)
                                                                        {
                                                                            SetSymptom4(inputFile.ReadLine());
                                                                            symptomProgress++;
                                                                        }

                                                                        if (symptomProgress < 7)
                                                                        {
                                                                            int lineNumberSymptom5 = 2;
                                                                            for (int i = 1; i < lineNumberSymptom5; i++)
                                                                            {
                                                                                SetSymptom5(inputFile.ReadLine());
                                                                                symptomProgress++;
                                                                            }

                                                                            if (symptomProgress < 8)
                                                                            {
                                                                                int lineNumberSymptom6 = 2;
                                                                                for (int i = 1; i < lineNumberSymptom6; i++)
                                                                                {
                                                                                    SetSymptom6(inputFile.ReadLine());
                                                                                    symptomProgress++;
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }




                            secondForm.Show();
                        }
                    }
                }

            }
        }
    }
}
