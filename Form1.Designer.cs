namespace ExamCSharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bLogin = new Button();
            bSignup = new Button();
            tbPassword = new TextBox();
            tbLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bLogin
            // 
            bLogin.Location = new Point(36, 292);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(119, 59);
            bLogin.TabIndex = 0;
            bLogin.Text = "Log in";
            bLogin.UseVisualStyleBackColor = true;
            bLogin.Click += bLogin_Click;
            // 
            // bSignup
            // 
            bSignup.BackgroundImageLayout = ImageLayout.None;
            bSignup.Location = new Point(212, 292);
            bSignup.Name = "bSignup";
            bSignup.Size = new Size(119, 59);
            bSignup.TabIndex = 1;
            bSignup.Text = "Sign up";
            bSignup.UseVisualStyleBackColor = true;
            bSignup.Click += bSignup_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(36, 224);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(295, 23);
            tbPassword.TabIndex = 2;
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(36, 150);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(295, 23);
            tbLogin.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 122);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 4;
            label1.Text = "Login/Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 196);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(129, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(371, 405);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbLogin);
            Controls.Add(tbPassword);
            Controls.Add(bSignup);
            Controls.Add(bLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BudgetManager";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bLogin;
        private Button bSignup;
        private TextBox tbPassword;
        private TextBox tbLogin;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}