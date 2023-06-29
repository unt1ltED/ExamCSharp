using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace praktik_21._06._2023
{
    internal class UsersManager
    {
        public List<User> Users { get; }

        public UsersManager()
        {
            Users = new List<User>();
        }

        public User? IsValid(string username, string password)
        {
            foreach(User user in Users)
            {
                if(user.Username == username)
                {
                    if (user.Password == password)
                        return user;

                    return null;
                }
            }

            return null;
        }

        public bool IfExists(string username)
        {
            object? matched = Users.Any(x => x.Username == username);
            return matched != null;
        }

        //public string

        //~UsersManager()
        //{
        //    using (FileStream f = new FileStream("users.json", FileMode.OpenOrCreate))
        //    {
        //        JsonSerializer.Serialize<UsersManager>(f, this);
        //    }
        //    MessageBox.Show("closed");
        //}
    }
}
