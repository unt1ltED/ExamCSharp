using System;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void bSpendingPage_Click(object sender, EventArgs e)
        {
            this.Close();
            SpendingPage form = new SpendingPage();
            form.Show();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Visible = true;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Visible = true;
        }
    }
}
