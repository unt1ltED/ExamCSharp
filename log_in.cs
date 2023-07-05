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
using ExamCSharp;

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
                MessageBox.Show("deserialized");
            }

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "") {
                User? user = usersManager.IsValid(textBox1.Text, textBox2.Text);
                if (user != null)
                {
                    MessageBox.Show("logged in");
                    //Form Form2 = new Form2();
                    string json = JsonSerializer.Serialize(user);

                    // Create the directory if it doesn't exist
                    string directoryPath = textBox1.Text;
                    Directory.CreateDirectory(directoryPath);

                    // Write the JSON string to the user.json file
                    string filePath = Path.Combine(directoryPath, "user.json");
                    File.WriteAllText(filePath, json);

                    Console.WriteLine("User object serialized and saved to user.json.");
                    Form Form2 = new Form2(textBox1.Text);
                    Form2.Show();
                    this.Hide();

                }
                else
                    MessageBox.Show("incorrect login or password");
            }
            else
                MessageBox.Show("both fields must be filled");

        }

        private void log_in_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("log_in form loaded");
        }
    }
}
