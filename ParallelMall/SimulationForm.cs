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
		private List<Case> cases;
		
		private void generateClients()
		{
			Random rand = new Random();
			while (true)
			{
				int time = rand.Next(250, 1000); //Czas oczekiwania
				Thread.Sleep(time);
				int queue = rand.Next(1, numberCases); //Kolejka do dołączenia się
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
			clientsGeneration = new Thread(new ThreadStart(generateClients));
			clientsGeneration.Start();
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
