using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParallelMall
{
    class Client
    {
        public int ProductType { get; set; } //produkt, którym zainteresowany jest klient
        public DateTime DateCreated { get; private set; }
        public bool Determined { get; private set; }

        public Client(int productType)
        {
            ProductType = productType;
            DateCreated = DateTime.Now;
            Random rand = new Random();
            if (rand.Next(0, 1) == 0) Determined = false;
            else Determined = true;
        }
    }
}
