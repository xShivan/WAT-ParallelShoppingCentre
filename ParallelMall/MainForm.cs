/*
 * Created by SharpDevelop.
 * User: michal
 * Date: 2014-06-14
 * Time: 13:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ParallelMall
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            nudProducts.Maximum = Global.MaximumProducts;
		}
		
		void BtnStartClick(object sender, EventArgs e)
		{
			SimulationForm sf = new SimulationForm((int)nudCases.Value, (int)nudProducts.Value, (int)nudProductCount.Value);
			sf.ShowDialog();
		}
	}
}
