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
            bSpendingPage = new Button();
            bEarningPage = new Button();
            bPlansPage = new Button();
            SuspendLayout();
            // 
            // bSpendingPage
            // 
            bSpendingPage.Location = new Point(71, 236);
            bSpendingPage.Name = "bSpendingPage";
            bSpendingPage.Size = new Size(169, 95);
            bSpendingPage.TabIndex = 0;
            bSpendingPage.Text = "SpendingPage";
            bSpendingPage.UseVisualStyleBackColor = true;
            // 
            // bEarningPage
            // 
            bEarningPage.Location = new Point(436, 236);
            bEarningPage.Name = "bEarningPage";
            bEarningPage.Size = new Size(169, 95);
            bEarningPage.TabIndex = 1;
            bEarningPage.Text = "EarningPage";
            bEarningPage.UseVisualStyleBackColor = true;
            // 
            // bPlansPage
            // 
            bPlansPage.Location = new Point(254, 343);
            bPlansPage.Name = "bPlansPage";
            bPlansPage.Size = new Size(169, 95);
            bPlansPage.TabIndex = 2;
            bPlansPage.Text = "PlansPage";
            bPlansPage.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 450);
            Controls.Add(bPlansPage);
            Controls.Add(bEarningPage);
            Controls.Add(bSpendingPage);
            Name = "MainPage";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button bSpendingPage;
        private Button bEarningPage;
        private Button bPlansPage;
    }
}