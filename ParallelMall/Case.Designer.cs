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
            this.gBoxCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxCase
            // 
            this.gBoxCase.Controls.Add(this.lblState);
            this.gBoxCase.Location = new System.Drawing.Point(3, 3);
            this.gBoxCase.Name = "gBoxCase";
            this.gBoxCase.Size = new System.Drawing.Size(144, 166);
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
            // Case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBoxCase);
            this.Name = "Case";
            this.Size = new System.Drawing.Size(150, 172);
            this.gBoxCase.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox gBoxCase;
	}
}
