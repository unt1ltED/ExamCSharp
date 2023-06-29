using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktik_21._06._2023
{
    public partial class log_in : Form
    {
        private UsersManager usersManager;
        public log_in()
        {
            InitializeComponent();
            usersManager = new UsersManager();
            using (FileStream f = new FileStream("users.json", FileMode.Open))
            {
                usersManager = JsonSerializer.Deserialize<UsersManager>(f);
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "") {
                User? user = usersManager.IsValid(textBox1.Text, textBox2.Text);
                if (user != null)
                {
                    MessageBox.Show("logged in");
                    //Form form2 = new Form2(user.Username, user.Password, user.ImageSource);
                    //form2.Show();
                    //this.Hide();

                }
                else
                    MessageBox.Show("incorrect login or password");
            }
            else
                MessageBox.Show("both fields must be filled");

        }
    }
}
