﻿using System;
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
        }
    }
}
