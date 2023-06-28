using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
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
    public partial class SpendingPage : Form
    {
        public SpendingPage()
        {
            InitializeComponent();
            //Form1 form = new Form1();
            //form.Hide();
        }

        private void PieChart()
        {
            pieChart1.Series = new ISeries[]
            {
                new PieSeries<double> { Values = new double[] { 2 } },
                new PieSeries<double> { Values = new double[] { 4 } },
                new PieSeries<double> { Values = new double[] { 1 } },
                new PieSeries<double> { Values = new double[] { 4 } },
                new PieSeries<double> { Values = new double[] { 3 } }
            };
        }

        private void CartChart()
        {
            cartesianChart1.Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                    Fill = null
                }
            };
        }

        private void bSpendingStats_Click(object sender, EventArgs e)
        {
            PieChart();
            CartChart();
        }
    }
}
