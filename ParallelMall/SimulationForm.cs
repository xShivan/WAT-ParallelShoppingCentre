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
        private List<Client> clientQueue;

        //Zwraca listę typów produktów, których już nie ma na półce
        private List<int> checkIfCaseIsEmpty(Case c)
        {
            List<int> productTypes = new List<int>();
            for (int i = 0; i < numberProductTypes; i++)
            {
                if (c.GetProductCount(i) <= 0) productTypes.Add(i);
            }
            return productTypes;
        }

        private void watchCases()
        {
            while(true)
            {
                List<int> emptyCases = checkIfCaseIsEmpty(cases[0]);
                if (emptyCases.Count != 0)
                {
                    cases[0].RefillingPreparation = true;
                    while (cases[0].Taking) Thread.Sleep(1); //Oczekiwanie aż klienci odpuszczą
                    foreach (int i in emptyCases)
                    {
                        cases[0].RefillProducts(i);
                    }
                }
                else Thread.Sleep(1000);
            }
        }

		private void generateClients()
		{
            
			Random rand = new Random();
			while (true)
			{
				int time = rand.Next(500, 1300); //Czas oczekiwania na dołączenie kolejnego klienta
				Thread.Sleep(time);
				int queue = rand.Next(0, numberCases - 1); //Numer kolejki do dołączenia się
                int productType = rand.Next(0, numberProductTypes);
                Client c = new Client(productType);
                clientQueue.Add(c);
                lblClientsIndicator.Text = "Clients: " + clientQueue.Count;
			}
		}

        private void consumeProducts()
        {
            while (true)
            {
                if (clientQueue.Count != 0)
                {
                    Thread.Sleep(500);
                    while (cases[0].RefillingPreparation || cases[0].Refilling) Thread.Sleep(1); //Łapy precz - pan chce nałożyć produkty
                    Client currentClient = clientQueue[0];
                    while (cases[0].GetProductCount(currentClient.ProductType) <= 0) Thread.Sleep(1);
                    cases[0].TakeProduct(currentClient.ProductType);
                    clientQueue.RemoveAt(0);
                    lblClientsIndicator.Text = "Clients: " + clientQueue.Count;
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
		}

        public void initializeSimulation()
        {
            clientQueue = new List<Client>();
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
            initializeSimulation();
		}
	}
}
