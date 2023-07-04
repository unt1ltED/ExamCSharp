namespace ExamCSharp
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            bSpendingPage = new Button();
            bEarningPage = new Button();
            bPlansPage = new Button();
            label1 = new Label();
            label2 = new Label();
            bExit = new Button();
            SuspendLayout();
            // 
            // bSpendingPage
            // 
            bSpendingPage.Location = new Point(34, 106);
            bSpendingPage.Name = "bSpendingPage";
            bSpendingPage.Size = new Size(169, 95);
            bSpendingPage.TabIndex = 0;
            bSpendingPage.Text = "SpendingPage";
            bSpendingPage.UseVisualStyleBackColor = true;
            bSpendingPage.Click += bSpendingPage_Click;
            // 
            // bEarningPage
            // 
            bEarningPage.Location = new Point(34, 343);
            bEarningPage.Name = "bEarningPage";
            bEarningPage.Size = new Size(169, 95);
            bEarningPage.TabIndex = 1;
            bEarningPage.Text = "EarningPage";
            bEarningPage.UseVisualStyleBackColor = true;
            // 
            // bPlansPage
            // 
            bPlansPage.Location = new Point(34, 225);
            bPlansPage.Name = "bPlansPage";
            bPlansPage.Size = new Size(169, 95);
            bPlansPage.TabIndex = 2;
            bPlansPage.Text = "PlansPage";
            bPlansPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(328, 32);
            label1.Name = "label1";
            label1.Size = new Size(262, 25);
            label1.TabIndex = 3;
            label1.Text = "Welcome to Budget Manager.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(376, 74);
            label2.Name = "label2";
            label2.Size = new Size(170, 21);
            label2.TabIndex = 4;
            label2.Text = "Pick the page you want";
            // 
            // bExit
            // 
            bExit.Location = new Point(530, 384);
            bExit.Name = "bExit";
            bExit.Size = new Size(138, 54);
            bExit.TabIndex = 5;
            bExit.Text = "Exit";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(680, 450);
            Controls.Add(bExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bPlansPage);
            Controls.Add(bEarningPage);
            Controls.Add(bSpendingPage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += MainPage_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSpendingPage;
        private Button bEarningPage;
        private Button bPlansPage;
        private Label label1;
        private Label label2;
        private Button bExit;
    }
}