/*
 * Created by SharpDevelop.
 * User: michal
 * Date: 2014-06-14
 * Time: 13:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ParallelMall
{
	/// <summary>
	/// Description of Case.
	/// </summary>
	public partial class Case : UserControl
	{
		private int productTypesCount;
        private int productQuantity;
		private List<int> counts;
        public bool Refilling { get; private set; }
        public bool RefillingPreparation { get; set; }
        public bool Taking { get; private set; }

        public int GetProductCount(int productType)
        {
            return counts[productType];
        }
		
		
		public Case(int caseId, int productTypesCount, int initialNumberOfProducts)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            productQuantity = initialNumberOfProducts;
			gBoxCase.Text = "Case " + caseId.ToString();
			this.Tag = caseId;
			this.productTypesCount = productTypesCount;
			
			counts = new List<int>();
			for (int i = 0; i < productTypesCount; i++)
			{
				counts.Add(initialNumberOfProducts);
			}
			updateControl();
		}

        delegate void updateControlDelegate();
		private void updateControl()
		{
            if (this.lblState.InvokeRequired)
            {
                updateControlDelegate d = new updateControlDelegate(updateControl);
                this.Invoke(d);
            }
            else
            {
                lblState.Text = String.Empty;
                for (int i = 0; i < productTypesCount; i++)
                {
                    lblState.Text = lblState.Text + "Product " + i + ": " + counts[i].ToString() + "\n";
                }
            }
		}

		
		public void RefillProducts(int ProductType)
		{
            Refilling = true;
            RefillingPreparation = false;
            while (counts[ProductType] < productQuantity)
            {
                counts[ProductType]++;
                updateControl();
                System.Threading.Thread.Sleep(250);
            }
            Refilling = false;
		}
		
		public void TakeProduct(int productType)
		{
            Taking = true;
			counts[productType]--;
			updateControl();
            Taking = false;
		}
	}
}
