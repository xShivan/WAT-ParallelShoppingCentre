using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParallelMall
{
    class Client
    {
        public int ProductType { get; set; } //produkt, którym zainteresowany jest klient

        public Client(int productType)
        {
            ProductType = productType;
        }
    }
}
