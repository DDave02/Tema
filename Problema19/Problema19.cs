using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema19
{
    class Problema19
    {
        static void Main(string[] args)
        {
            //Nu este precis figura geometrica asa ca calculul ariei este posibil sa nu fie corect. Sunt 3 laturi a b si c, dar ii 
            //posibil ca oricare sa fie inaltime sau o latura.
            double a, b, c;
            Console.WriteLine("Introduceti cele trei numere a,b si c pe linii separate.");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Ce doriti sa calculam? Aria sau perimetrul");
            string s = Console.ReadLine();
            if (s == "aria")
            {
                Console.WriteLine($"Aria este {a*b/c}.");
            }
            else
                Console.WriteLine($"Perimetrul este {a+b+c}.");
        }
    }
}
