using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ParallelMall
{
    class Global
    {
        static public Color GetColor(int id)
        {
            switch (id)
            {
                case 0:
                    return Color.Black;
                case 1:
                    return Color.Blue;
                case 2:
                    return Color.Red;
                case 3:
                    return Color.Green;
                case 4:
                    return Color.Purple;
                case 5:
                    return Color.DarkGray;
                case 6:
                    return Color.Yellow;
                case 7:
                    return Color.DarkCyan;
                default:
                    return Color.Black;
            }
        }

        public const int MaximumProducts = 8;
        public static int waitTime = 5; //Sekundy
    }
}
