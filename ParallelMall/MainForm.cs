using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ParallelMall
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
            nudProducts.Maximum = Global.MaximumProducts;
		}
		
		void BtnStartClick(object sender, EventArgs e)
		{
			SimulationForm sf = new SimulationForm((int)nudCases.Value, (int)nudProducts.Value, (int)nudProductCount.Value, cBoxAllowNonDetermined.Checked);
			sf.ShowDialog();
		}
	}
}
