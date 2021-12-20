using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema34
{
    class Problema34
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade sau radiani? (Dati valoarea cu litera mica, altfel va transforma gresit)");
            string s = Console.ReadLine();
            int r_deg = int.Parse(Console.ReadLine());
            if(s=="radiani")
            {
                Console.WriteLine($"{r_deg} radiani in grade este: "+ ConvertToRad(r_deg));
            }
            else
            {
                Console.WriteLine($"{r_deg} grade in radiani este: " +ConvertToGrad(r_deg));
            }


        }

        private static double ConvertToGrad(double r_deg)
        {
            double rad = (Math.PI / 180) * r_deg;
            return rad;
        }

        private static double ConvertToRad(double r_deg)
        {
            double grade = (180 / Math.PI) * r_deg;
            return grade;
        }
    }
}
