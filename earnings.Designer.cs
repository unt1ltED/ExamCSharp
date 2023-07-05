namespace ExamCSharp
{
    partial class earnings
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("no earnings yet(");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "no earnings yet(";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(369, 266);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pieChart1
            // 
            this.pieChart1.InitialRotation = 0D;
            this.pieChart1.IsClockwise = true;
            this.pieChart1.Location = new System.Drawing.Point(477, 128);
            this.pieChart1.MaxAngle = 360D;
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(150, 150);
            this.pieChart1.TabIndex = 4;
            this.pieChart1.Total = null;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(477, 119);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(150, 150);
            this.cartesianChart1.TabIndex = 5;
            // 
            // earnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.treeView1);
            this.Name = "earnings";
            this.Text = "earnings";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView treeView1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}