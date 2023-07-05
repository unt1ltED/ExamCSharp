using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCSharp
{
    internal class Work
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Work(string name, double amount, DateTime date)
        {
            Name = name;
            Amount = amount;
            Date = date;
        }
    }
}
