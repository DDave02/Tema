using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema13
{
    class Problema13
    {
        static void Main(string[] args)
        {
            //initializare
            double Celsius, Fahrenheit, max = 300;
            //generare a 300 de valori celsius-fahrenheit
            for (Celsius = 0; Celsius <= max; Celsius++)
            {
                Fahrenheit = Celsius* 1.8+32;
                Console.Write($"Celsius={Celsius} este in Fahrenheit={Fahrenheit}");
                Console.WriteLine();
            }
        }
    }
}
