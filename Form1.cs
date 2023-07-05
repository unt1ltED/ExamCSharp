using System.Text.Json;
using System.Text.Json.Serialization;
using ExamCSharp;

namespace praktik_21._06._2023
{
    public partial class sign_up : Form
    {
        private string captcha;
        private UsersManager usersManager;
        private string filePath;
        
        //public UsersManager UserosManager { get;  }
        public sign_up()
        {
            InitializeComponent();
            
            usersManager = new UsersManager();

            filePath = "users.json";
            if (File.Exists(filePath))
            {
                using (FileStream f = new FileStream(filePath, FileMode.Open))
                {
                    usersManager = JsonSerializer.Deserialize<UsersManager>(f);
                }
            }
            else linkLabel1.Hide();

            label6.Text = "";
            label4.Text = "";
            label7.Text = "";
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    string username = textBox1.Text;
                    if (!usersManager.IfExists(Text) || username.Length < 3 || username.Length > 20)
                    {
                        textBox1.Text = "";
                        label6.Text = "3 - 20 symbols length and unique";
                    }

                    else
                    {
                        label6.Text = "";
                    }

                    string password = textBox2.Text;
                    if (password.ToUpper() == password || password.ToLower() == password
                        || !password.Any(symbol => char.IsDigit(symbol)) || !password.Any(symbol => char.IsLetter(symbol)
                        || password.Length < 8 || password.Length > 20))
                    {
                        textBox2.Text = "";
                        label4.Text = "a A 123, length 8-20";
                    }
                    else
                    {
                        label4.Text = "";
                    }

                    string repeatedPassword = textBox3.Text;
                    if (repeatedPassword != password)
                    {
                        textBox3.Text = "";
                        label7.Text = "doesn`t match";
                    }
                    else
                    {
                        label7.Text = "";
                    }

                    if (label6.Text == label4.Text && label7.Text == label6.Text)
                    //all empty which implies that everything is right
                    {
                        usersManager.Users.Add(new User(textBox1.Text, textBox2.Text));
                        using (FileStream f = new FileStream("users.json", FileMode.OpenOrCreate))
                        {
                            JsonSerializer.Serialize<UsersManager>(f, usersManager);
                        }
                        Form log_in = new log_in();
                        log_in.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("all fields must be filled");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool IsImagePathValid(string filePath)
        {
            try
            {
                using (Image image = Image.FromFile(filePath))
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }                   

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            Form log_in = new log_in();
            log_in.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }
    }
}