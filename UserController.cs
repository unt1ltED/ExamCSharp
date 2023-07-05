using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamCSharp;

namespace ExamCSharp
{
    internal class UserController
    {
        protected string filePath;
        protected User user;

        public UserController(string filePath)
        {
            this.filePath = filePath;
            GetUser();
            //user = new User();
        }

        private void GetUser()
        {
            if (File.Exists(filePath + "\\user.json"))
            {
                using (FileStream f = new FileStream(filePath + "\\user.json", FileMode.Open))
                {
                    user = JsonSerializer.Deserialize<User>(f);
                }
            }
            else MessageBox.Show("couldn`t open the user file");
        }
    }
}
