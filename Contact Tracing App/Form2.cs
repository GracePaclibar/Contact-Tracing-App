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

        public static string FirstName = "";
        public static string MidName = "";
        public static string LastName = "";
        public static string Address = "";
        public static string Age = "";
        public static string Sex = "";
        public static string Date = "";
        public static string ContactNumber = "";
        public static string Destination = "";


        private void Form2_Load(object sender, EventArgs e)
        {
            txtBoxFirstName.Text = ContactTracing.FirstName;
            txtBoxMidName.Text = ContactTracing.MidName;
        }
    }
}
