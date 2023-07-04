using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView.WinForms;
using HarfBuzzSharp;

namespace ExamCSharp
{
    public partial class SpendingPage : Form
    {
        public SpendingPage()
        {
            InitializeComponent();
        }

        private void CartChart()
        {

            if (File.Exists(@"UserName\" + dtpMonthYear.Value.Year + @"\" + dtpMonthYear.Value.Month + @"\" + cbCategory.Text + @".json")) //Заменить UserName на переменную "Login"
            {
                List<Spending> charts = JsonConvert.DeserializeObject<List<Spending>>(File.ReadAllText(@"UserName\" + dtpMonthYear.Value.Year + @"\" + dtpMonthYear.Value.Month + @"\" + cbCategory.Text + @".json")); //Заменить UserName на переменную "Login"
                List<double> t = new List<double>();
                List<string> t2 = new List<string>();
                List<string> t3 = new List<string>();
                foreach (var item in charts)
                {
                    t.Add(item.Amount);
                    t2.Add(item.Date);
                    t3.Add(item.Title);
                };

                cartesianChart1.Series = new ISeries[]
                {
                new ColumnSeries<double>
                {
                    Values = t,

                }
                };

                cartesianChart1.XAxes = new Axis[]
                {
                new Axis
                {
                    Labels = t2,
                    NamePaint = new SolidColorPaint(SKColors.Black),

                    LabelsPaint = new SolidColorPaint(SKColors.Blue),
                    TextSize = 12,

                    SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray) { StrokeThickness = 2 }
                }
                };
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }


        private void bSpendingStats_Click(object sender, EventArgs e)
        {
            CartChart();
        }

        private void bAddSpending_Click(object sender, EventArgs e)
        {
            AddSpendingForm add = new AddSpendingForm();
            add.Show();
        }

        private void SpendingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}
