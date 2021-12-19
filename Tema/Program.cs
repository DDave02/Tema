using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declararea datelor
            string tip_temperatura;
            double temperatura, temp_final=0;
            //Citirea datelor
            Console.WriteLine("Introduceti tipul de temperatura initiala");
            Console.WriteLine("Celsius sau Fahrenheit (prima litera trebuie sa fie majuscula)");
            tip_temperatura=Console.ReadLine();
            Console.WriteLine("Introduceti temperatura: ");
            temperatura = double.Parse(Console.ReadLine());
            //Switch pentru Tipuri de temp.
            switch(tip_temperatura)
            {
                case "Celsius":
                    temp_final = temperatura * 1.8 + 32;
                    Console.WriteLine($"Temperatura {temperatura} Celsius este {temp_final} in Fahrenheit");
                    break;
                case "Fahrenheit":
                    temp_final = (temperatura- 32) / 1.8;
                    Console.WriteLine($"Temperatura {temperatura} Fahrenheit este {temp_final} in Celsius");
                    break;
                default:
                    Console.WriteLine("Ati introdus tipul de temperatura gresit. Restartati programul.");
                    break;
            }
        }
    }
}
