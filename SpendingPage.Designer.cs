namespace ExamCSharp
{
    partial class SpendingPage
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
            bSpendingStats = new Button();
            bAddSpending = new Button();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cbCategory = new ComboBox();
            label1 = new Label();
            dtpMonthYear = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // bSpendingStats
            // 
            bSpendingStats.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bSpendingStats.Location = new Point(46, 344);
            bSpendingStats.Name = "bSpendingStats";
            bSpendingStats.Size = new Size(181, 77);
            bSpendingStats.TabIndex = 0;
            bSpendingStats.Text = "SpendingStats";
            bSpendingStats.UseVisualStyleBackColor = true;
            bSpendingStats.Click += bSpendingStats_Click;
            // 
            // bAddSpending
            // 
            bAddSpending.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bAddSpending.Location = new Point(46, 442);
            bAddSpending.Name = "bAddSpending";
            bAddSpending.Size = new Size(181, 77);
            bAddSpending.TabIndex = 1;
            bAddSpending.Text = "AddSpending";
            bAddSpending.UseVisualStyleBackColor = true;
            bAddSpending.Click += bAddSpending_Click;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(46, 33);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(334, 283);
            cartesianChart1.TabIndex = 3;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Food", "GYM", "Supermarket" });
            cbCategory.Location = new Point(417, 33);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(218, 23);
            cbCategory.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 15);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 5;
            label1.Text = "Choice Category";
            // 
            // dtpMonthYear
            // 
            dtpMonthYear.Location = new Point(417, 83);
            dtpMonthYear.Name = "dtpMonthYear";
            dtpMonthYear.Size = new Size(218, 23);
            dtpMonthYear.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 65);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 7;
            label2.Text = "Choice Month and Year";
            // 
            // SpendingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(label2);
            Controls.Add(dtpMonthYear);
            Controls.Add(label1);
            Controls.Add(cbCategory);
            Controls.Add(cartesianChart1);
            Controls.Add(bAddSpending);
            Controls.Add(bSpendingStats);
            Name = "SpendingPage";
            Text = "SpendingPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSpendingStats;
        private Button bAddSpending;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private ComboBox cbCategory;
        private Label label1;
        private DateTimePicker dtpMonthYear;
        private Label label2;
    }
}