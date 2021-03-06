﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ParallelMall
{
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
            if (this.txtBoxState.InvokeRequired)
            {
                updateControlDelegate d = new updateControlDelegate(updateControl);
                this.Invoke(d);
            }
            else
            {
                txtBoxState.Text = String.Empty;
                for (int i = 0; i < productTypesCount; i++)
                {
                    string appendix = "Product " + i + ": " + counts[i].ToString() + "\n";
                    txtBoxState.AppendText(appendix);
                    txtBoxState.Select(txtBoxState.Text.Length - appendix.Length, txtBoxState.Text.Length);
                    txtBoxState.SelectionColor = Global.GetColor(i);
                    txtBoxState.DeselectAll();
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
                System.Threading.Thread.Sleep(500);
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
