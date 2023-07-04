namespace ExamCSharp
{
    partial class AddSpendingForm
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
            bAdd = new Button();
            tbTitle = new TextBox();
            label1 = new Label();
            cbCategory = new ComboBox();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            tbAmount = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // bAdd
            // 
            bAdd.Location = new Point(162, 141);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 0;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(12, 32);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(160, 23);
            tbTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Food", "GYM", "Supermarket" });
            cbCategory.Location = new Point(12, 78);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(160, 23);
            cbCategory.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Category";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(185, 32);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 14);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 7;
            label3.Text = "Date";
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(185, 78);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(200, 23);
            tbAmount.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 60);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Amount";
            // 
            // AddSpendingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 176);
            Controls.Add(label4);
            Controls.Add(tbAmount);
            Controls.Add(label3);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(cbCategory);
            Controls.Add(label1);
            Controls.Add(tbTitle);
            Controls.Add(bAdd);
            Name = "AddSpendingForm";
            Text = "AddSpendingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bAdd;
        private TextBox tbTitle;
        private Label label1;
        private ComboBox cbCategory;
        private Label label2;
        private DateTimePicker dtpDate;
        private Label label3;
        private TextBox tbAmount;
        private Label label4;
    }
}