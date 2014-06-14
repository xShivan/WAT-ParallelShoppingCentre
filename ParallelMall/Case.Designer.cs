/*
 * Created by SharpDevelop.
 * User: michal
 * Date: 2014-06-14
 * Time: 13:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ParallelMall
{
	partial class Case
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
            this.gBoxCase = new System.Windows.Forms.GroupBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblRefill = new System.Windows.Forms.Label();
            this.gBoxCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxCase
            // 
            this.gBoxCase.Controls.Add(this.lblState);
            this.gBoxCase.Location = new System.Drawing.Point(3, 26);
            this.gBoxCase.Name = "gBoxCase";
            this.gBoxCase.Size = new System.Drawing.Size(144, 121);
            this.gBoxCase.TabIndex = 0;
            this.gBoxCase.TabStop = false;
            this.gBoxCase.Text = "Case";
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(7, 20);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(99, 62);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "STATE";
            // 
            // lblRefill
            // 
            this.lblRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRefill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRefill.Location = new System.Drawing.Point(3, 0);
            this.lblRefill.Name = "lblRefill";
            this.lblRefill.Size = new System.Drawing.Size(132, 23);
            this.lblRefill.TabIndex = 0;
            this.lblRefill.Text = "Refilling products";
            this.lblRefill.Visible = false;
            // 
            // Case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBoxCase);
            this.Controls.Add(this.lblRefill);
            this.Name = "Case";
            this.gBoxCase.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lblRefill;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.GroupBox gBoxCase;
	}
}
