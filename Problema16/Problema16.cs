using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema16
{
    class Problema16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati numarul de foi: ");
            int n=int.Parse(Console.ReadLine()), r;
            Console.WriteLine("Dati numarul de randuri pe o pagina.");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cartea are {2*n*r} randuri.");
        }
    }
}
