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
            this.bPlansPage = new System.Windows.Forms.Button();
            this.bEarningPage = new System.Windows.Forms.Button();
            this.bSpendingPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bPlansPage
            // 
            this.bPlansPage.Location = new System.Drawing.Point(35, 207);
            this.bPlansPage.Name = "bPlansPage";
            this.bPlansPage.Size = new System.Drawing.Size(169, 95);
            this.bPlansPage.TabIndex = 5;
            this.bPlansPage.Text = "PlansPage";
            this.bPlansPage.UseVisualStyleBackColor = true;
            // 
            // bEarningPage
            // 
            this.bEarningPage.Location = new System.Drawing.Point(35, 334);
            this.bEarningPage.Name = "bEarningPage";
            this.bEarningPage.Size = new System.Drawing.Size(169, 95);
            this.bEarningPage.TabIndex = 4;
            this.bEarningPage.Text = "EarningPage";
            this.bEarningPage.UseVisualStyleBackColor = true;
            this.bEarningPage.Click += new System.EventHandler(this.bEarningPage_Click);
            // 
            // bSpendingPage
            // 
            this.bSpendingPage.Location = new System.Drawing.Point(35, 78);
            this.bSpendingPage.Name = "bSpendingPage";
            this.bSpendingPage.Size = new System.Drawing.Size(169, 95);
            this.bSpendingPage.TabIndex = 3;
            this.bSpendingPage.Text = "SpendingPage";
            this.bSpendingPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(463, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "UserName";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPlansPage);
            this.Controls.Add(this.bEarningPage);
            this.Controls.Add(this.bSpendingPage);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bPlansPage;
        private Button bEarningPage;
        private Button bSpendingPage;
        private Label label1;
    }
}