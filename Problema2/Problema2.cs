using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Problema2
    {
        static void Main(string[] args)
        {
            //Declaraea datelor
            double x=0, y=0;
            string semne;
            //Citirea datelor
            Console.WriteLine("Dati semnul pentru operatia ceruta");
            Console.WriteLine("Mentiuni: + pentru adunare, - pentru scadere, * pentru inmultire, / pentru impartire, R pentru radical, || pentru modul(fara spatiu)");
            semne = Console.ReadLine();
            //Verificarea in caaz daca avem nevoie de 1 nr sau 2
            if(semne=="R" || semne=="||")
            {
                Console.WriteLine("Dati un numar: ");
                x = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Dati doua numere pe randuri diferite: ");
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
            }
            //Calculare
            switch (semne)
            {
                case "+":
                    Console.WriteLine("Suma este: " + (x + y));
                    break;
                case "-":
                    Console.WriteLine("Diferenta este: " + (x - y));
                    break;
                case "*":
                    Console.WriteLine("Produsul este: " + (x * y));
                    break;
                case "/":
                    Console.WriteLine("Rezulatul impartirii este: " + (x / y));
                    break;
                case "R":
                    Console.WriteLine("Rezultatul radicalului este: "+Math.Sqrt(x));
                    break;
                case "||":
                    Console.WriteLine("Modulul este: " + Math.Abs(x));
                    break;
                default:
                    Console.WriteLine("Ati introdus ceva gresit");
                    break;
            }
        }
    }
}
