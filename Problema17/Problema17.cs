using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema17
{
    class Problema17
    {
        static void Main(string[] args)
        {
            // Deoarece nu se stie in ce sunt precizate datele x0 x si t0 si t nu am pus U.M. in S.I.
            double x0, t0, t, x;
            Console.Write("Dati valoare x0: ");
            x0 = double.Parse(Console.ReadLine());
            Console.Write("Dati valoarea t0: ");
            t0 = double.Parse(Console.ReadLine());
            Console.Write("Dati valoarea x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Dati valoare t: ");
            t = double.Parse(Console.ReadLine());
            Console.WriteLine($"Viteza punctului material este de {(x-x0)/(t-t0)}");
        }
    }
}
