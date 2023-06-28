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
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
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
            // 
            // pieChart1
            // 
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(46, 37);
            pieChart1.MaxAngle = 360D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(286, 283);
            pieChart1.TabIndex = 2;
            pieChart1.Total = null;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(437, 37);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(334, 283);
            cartesianChart1.TabIndex = 3;
            // 
            // SpendingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(cartesianChart1);
            Controls.Add(pieChart1);
            Controls.Add(bAddSpending);
            Controls.Add(bSpendingStats);
            Name = "SpendingPage";
            Text = "SpendingPage";
            ResumeLayout(false);
        }

        #endregion

        private Button bSpendingStats;
        private Button bAddSpending;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}