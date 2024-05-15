using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emne_3_KalkulatorDebugg.console
{
    public class Kalkulator
    {
        public int LeggSammen(int a, int b)
        {
            return a + b;
        }

        public int TrekkFra(int a, int b)
        {
            return a - b;
        }

        public int Multipliser(int a, int b)
        {
            return a * b;
        }

        //koden feiler på ikke hele tall (kan fikses med og gjøre return og param values til double)
        public int Divider(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
