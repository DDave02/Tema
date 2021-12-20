using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema12
{
    class Problema12
    {
        static void Main(string[] args)
        {
            //Initializare
            double Celsius, Fahrenheit,max=300;
            //Generare a celor 300 de valori fahrenheit-celsius
            for (Fahrenheit=0; Fahrenheit <= max; Fahrenheit++)
            {
                Celsius = (Fahrenheit - 32) / 1.8;
                Console.Write($"Fahrenheit={Fahrenheit} este in Celsius={Math.Round(Celsius, 2)}");
                Console.WriteLine();
            }
        }
    }
}
