using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema39
{
    class Problema39
    {
        static void Main(string[] args)
        {
            //Fie 2 vectori. ora1 reprezinta primele date de timp date, ora2 a doua. Elementul 0 este ora, Elementul 1 este minutul si elementul 2 este Secunda.
            Console.WriteLine("Dati 3 date de timp separate in aceasta ordine si conditii. 0<= Ora <= 23, 0<= Minut <= 59, 0<= secunda <=59 ");
            int a, b, c;
            int difo,difmin,difsec;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int[] ora1 = { a, b, c };
            Console.WriteLine("Dati alte trei valori cu acelasi conditii");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int[] ora2 = { a, b, c };

            if (ora2[0] - ora1[0] < 0)
                difo = Math.Abs(ora2[0] - ora1[0]);
            else
                difo = ora2[0] - ora1[0];
            if (ora2[1] - ora1[1] < 0)
            {
                if (difo - 1 < 0)
                    difmin = Math.Abs(ora2[1] - ora1[1]);
                else
                {
                    difmin = ora2[1] - ora1[1] + 60;
                    difo--;
                }
            }
            else
                difmin = ora2[1] - ora1[2];
            if (ora2[2] - ora1[2] <= 0)
            {
                if (difmin - 1 < 0)
                {
                    if (difo - 1 < 0)
                        difsec = Math.Abs(ora2[2] - ora1[2]);
                    else
                    {
                        difo--;
                        difmin += 60;
                        difmin--;
                        difsec = ora2[2] + 60 - ora1[2];
                    }
                }
                else
                {
                    difmin--;
                    difsec = ora2[2] + 60 - ora1[2];
                }

            }
            else
                difsec = ora2[2] - ora1[2];

            difsec = Math.Abs(ora2[2] - ora1[2]);
            Console.WriteLine($"Diferenta dintre cele 2 valori ale timpului este de {difo} ore, {difmin} minute si {difsec} secunde.");
        }
    }
}
