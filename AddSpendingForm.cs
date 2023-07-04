﻿using Newtonsoft.Json;
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

namespace ExamCSharp
{
    public partial class AddSpendingForm : Form
    {
        string Title;
        double Amount;
        string Category;
        int Day;
        int Month;
        int Year;
        string Date;

        public AddSpendingForm()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            double temp;

            if (Double.TryParse(tbAmount.Text.ToString(), out temp))
            {
                Title = tbTitle.Text.ToString();
                Amount = Double.Parse(tbAmount.Text.ToString());
                Category = cbCategory.Text.ToString();
                Day = dtpDate.Value.Day;
                Month = dtpDate.Value.Month;
                Year = dtpDate.Value.Year;
                Date = dtpDate.Value.ToShortDateString();

                //MessageBox.Show($"Title: {Title}\nAmount: {Amount}\nCategory: {Category}\nDate: {Day}.{Month}.{Year}", "TestBox");
                Spending(Title, Amount, Category, Date);
            }

            else 
            {
                MessageBox.Show("Error! Invalid data type of Amount");
            }
        }

        public void Spending(string ti,double a, string c, string d) 
        {
            if (!Directory.Exists(@"UserName\" + Year + @"\" + Month))
            {
                Directory.CreateDirectory(@"UserName\" + Year + @"\" + Month);
                if (!File.Exists(@"UserName\" + Year + @"\" + Month + @"\" + c + @".json"))
                {
                    List<Spending> t = new List<Spending>();
                    File.Create(@"UserName\" + Year + @"\" + Month + @"\" + c + @".json");
                    Spending addSpending = new Spending()
                    {
                        Title = ti,
                        Amount = a,
                        Category = c,
                        Date = d
                    };

                    t.Add(addSpending);

                    File.WriteAllText(@"UserName\" + Year + @"\" + Month + @"\" + c + @".json", JsonConvert.SerializeObject(t, Formatting.Indented,
new JsonSerializerSettings
{
ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
}));


                }
            }
            else
            {
                if (!File.Exists(@"UserName\" + Year + @"\" + Month + @"\" + c + @".json"))
                {
                    List<Spending> t = new List<Spending>();
                    //File.Create(@"UserName\" + Year + @"\" + Month + @"\" + c + @".json");

                    Spending addSpending = new Spending()
                    {
                        Title = ti,
                        Amount = a,
                        Category = c,
                        Date = d
                    };

                    t.Add(addSpending);

                    File.WriteAllText(@"UserName\" + Year + @"\" + Month + @"\" + c + @".json", JsonConvert.SerializeObject(t, Formatting.Indented,
new JsonSerializerSettings
{
ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
}));

                }
                else
                {
                    List<Spending> add = JsonConvert.DeserializeObject<List<Spending>>(File.ReadAllText(@"UserName\" + Year + @"\" + Month + @"\" + c + @".json"));
                    Spending addSpending = new Spending()
                    {
                        Title = ti,
                        Amount = a,
                        Category = c,
                        Date = d
                    };

                    add.Add(addSpending);
                    File.WriteAllText(@"UserName\" + Year + @"\" + Month + @"\" + c + @".json", JsonConvert.SerializeObject(add, Formatting.Indented,
new JsonSerializerSettings
{
ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
}));

                }
            }
            this.Close();

        }
    }
}
