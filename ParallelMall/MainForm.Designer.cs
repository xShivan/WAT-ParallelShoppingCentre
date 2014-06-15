/*
 * Created by SharpDevelop.
 * User: michal
 * Date: 2014-06-14
 * Time: 13:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ParallelMall
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudCases = new System.Windows.Forms.NumericUpDown();
            this.nudProducts = new System.Windows.Forms.NumericUpDown();
            this.nudProductCount = new System.Windows.Forms.NumericUpDown();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.cBoxAllowNonDetermined = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulation settings";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of cases:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Types of products:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(257, 129);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // nudCases
            // 
            this.nudCases.Location = new System.Drawing.Point(141, 31);
            this.nudCases.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCases.Name = "nudCases";
            this.nudCases.Size = new System.Drawing.Size(120, 20);
            this.nudCases.TabIndex = 8;
            this.nudCases.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudProducts
            // 
            this.nudProducts.Location = new System.Drawing.Point(141, 57);
            this.nudProducts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProducts.Name = "nudProducts";
            this.nudProducts.Size = new System.Drawing.Size(120, 20);
            this.nudProducts.TabIndex = 9;
            this.nudProducts.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudProductCount
            // 
            this.nudProductCount.Location = new System.Drawing.Point(141, 83);
            this.nudProductCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProductCount.Name = "nudProductCount";
            this.nudProductCount.Size = new System.Drawing.Size(120, 20);
            this.nudProductCount.TabIndex = 11;
            this.nudProductCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblProductCount
            // 
            this.lblProductCount.Location = new System.Drawing.Point(12, 85);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(123, 23);
            this.lblProductCount.TabIndex = 10;
            this.lblProductCount.Text = "Product quantity:";
            // 
            // cBoxAllowNonDetermined
            // 
            this.cBoxAllowNonDetermined.AutoSize = true;
            this.cBoxAllowNonDetermined.Location = new System.Drawing.Point(15, 112);
            this.cBoxAllowNonDetermined.Name = "cBoxAllowNonDetermined";
            this.cBoxAllowNonDetermined.Size = new System.Drawing.Size(160, 17);
            this.cBoxAllowNonDetermined.TabIndex = 12;
            this.cBoxAllowNonDetermined.Text = "Allow non-determined clients";
            this.cBoxAllowNonDetermined.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 164);
            this.Controls.Add(this.cBoxAllowNonDetermined);
            this.Controls.Add(this.nudProductCount);
            this.Controls.Add(this.lblProductCount);
            this.Controls.Add(this.nudProducts);
            this.Controls.Add(this.nudCases);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ParallelMall";
            ((System.ComponentModel.ISupportInitialize)(this.nudCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label lblProductCount;
		private System.Windows.Forms.NumericUpDown nudProductCount;
		private System.Windows.Forms.NumericUpDown nudProducts;
		private System.Windows.Forms.NumericUpDown nudCases;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBoxAllowNonDetermined;
	}
}
