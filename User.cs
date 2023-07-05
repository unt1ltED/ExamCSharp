using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExamCSharp
{
    internal class User
    {
        public string Username { get; }
        public string Password { get; }
        //public List<Plan> plans { get; set; }
        public List<Work> MainJobs { get; set; }
        public List<Work> Additional { get; set; }
        //public List<Spending> Spendings { get; set; }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            MainJobs = new List<Work>();
            Additional = new List<Work>();
        }
    }
}
