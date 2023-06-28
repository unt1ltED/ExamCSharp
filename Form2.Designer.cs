namespace ExamCSharp
{
    partial class Form2
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
            bPlansPage = new Button();
            bEarningPage = new Button();
            bSpendingPage = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bPlansPage
            // 
            bPlansPage.Location = new Point(35, 207);
            bPlansPage.Name = "bPlansPage";
            bPlansPage.Size = new Size(169, 95);
            bPlansPage.TabIndex = 5;
            bPlansPage.Text = "PlansPage";
            bPlansPage.UseVisualStyleBackColor = true;
            // 
            // bEarningPage
            // 
            bEarningPage.Location = new Point(35, 334);
            bEarningPage.Name = "bEarningPage";
            bEarningPage.Size = new Size(169, 95);
            bEarningPage.TabIndex = 4;
            bEarningPage.Text = "EarningPage";
            bEarningPage.UseVisualStyleBackColor = true;
            // 
            // bSpendingPage
            // 
            bSpendingPage.Location = new Point(35, 78);
            bSpendingPage.Name = "bSpendingPage";
            bSpendingPage.Size = new Size(169, 95);
            bSpendingPage.TabIndex = 3;
            bSpendingPage.Text = "SpendingPage";
            bSpendingPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(463, 110);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 6;
            label1.Text = "UserName";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 450);
            Controls.Add(label1);
            Controls.Add(bPlansPage);
            Controls.Add(bEarningPage);
            Controls.Add(bSpendingPage);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bPlansPage;
        private Button bEarningPage;
        private Button bSpendingPage;
        private Label label1;
    }
}