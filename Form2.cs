﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCSharp
{
    public partial class Form2 : Form
    {
        private string username;
        public Form2(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void bEarningPage_Click(object sender, EventArgs e)
        {
            Form earnings = new earnings(username);
            earnings.Show();
            this.Hide();
        }
    }
}
