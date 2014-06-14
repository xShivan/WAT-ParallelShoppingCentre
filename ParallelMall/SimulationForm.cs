/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: michal
 * Data: 2014-06-14
 * Godzina: 13:33
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ParallelMall
{
	/// <summary>
	/// Description of SimulationForm.
	/// </summary>
	public partial class SimulationForm : Form
	{
		private int numberCases;
		private int numberProductTypes;
		private int numberOfProducts;
		private Thread clientsGeneration;
        private Thread productsConsumption;
        private Thread casesWatching;
		private List<Case> cases;
        private List<int> clientQueue;

        private void watchCases()
        {
            while(true)
            {
                if (cases[0].GetProductCount(0) == 0)
                {
                    cases[0].RefillProducts(0);
                }
                else Thread.Sleep(1000);
            }
        }

		private void generateClients()
		{
            clientQueue = new List<int>();
			Random rand = new Random();
			while (true)
			{
				int time = rand.Next(500, 1300); //Czas oczekiwania na dołączenie kolejnego klienta
				Thread.Sleep(time);
				int queue = rand.Next(0, numberCases - 1); //Numer kolejki do dołączenia się
                clientQueue.Add(1);
                lblClientsIndicator.Text = "Clients: " + clientQueue.Count;
			}
		}

        private void consumeProducts()
        {
            while (true)
            {
                if (clientQueue.Count != 0)
                {
                    Thread.Sleep(1000);
                    cases[0].TakeProduct(0);
                    clientQueue.RemoveAt(0);
                }
                else Thread.Sleep(1);
            }
        }
		
		private void initializeVisualisation()
		{
			cases = new List<Case>();
			for (int i = 0; i < numberCases; i++)
			{
				Case c = new Case(i + 1, numberProductTypes, numberOfProducts);
				c.Location = new System.Drawing.Point(i *150, 5);
				this.Controls.Add(c);
				cases.Add(c);
				if (i == numberCases - 1)
				{
					this.Size = new Size((i + 1) * 155, 200);
				}
			}

            casesWatching = new Thread(new ThreadStart(watchCases));
            casesWatching.Start();

			clientsGeneration = new Thread(new ThreadStart(generateClients));
			clientsGeneration.Start();

            productsConsumption = new Thread(new ThreadStart(consumeProducts));
            productsConsumption.Start();
		}
		
		public SimulationForm(int casesCount, int typesCount, int productCount)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.numberCases = casesCount;
			this.numberProductTypes = typesCount;
			this.numberOfProducts = productCount;
			
			initializeVisualisation();
		}
	}
}
