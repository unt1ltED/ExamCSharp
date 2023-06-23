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
            bSpendingPage = new Button();
            bEarningPage = new Button();
            SuspendLayout();
            // 
            // bSpendingPage
            // 
            bSpendingPage.Location = new Point(127, 236);
            bSpendingPage.Name = "bSpendingPage";
            bSpendingPage.Size = new Size(169, 95);
            bSpendingPage.TabIndex = 0;
            bSpendingPage.Text = "button1";
            bSpendingPage.UseVisualStyleBackColor = true;
            // 
            // bEarningPage
            // 
            bEarningPage.Location = new Point(370, 236);
            bEarningPage.Name = "bEarningPage";
            bEarningPage.Size = new Size(169, 95);
            bEarningPage.TabIndex = 1;
            bEarningPage.Text = "button2";
            bEarningPage.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 450);
            Controls.Add(bEarningPage);
            Controls.Add(bSpendingPage);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button bSpendingPage;
        private Button bEarningPage;
    }
}