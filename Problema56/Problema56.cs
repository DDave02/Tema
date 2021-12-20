using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema56
{
    class Problema56
    {
        static void Main(string[] args)
        {
            int[] v = new int[21];
            v[0] = 1;
            v[1] = 1;
            Console.WriteLine("Primi 21 de termeni ai lui fibonacci sunt: ");
            for(int i=2;i<21;i++)
            {
                v[i] = v[i - 1] + v[i - 2];
            }
            for(int i=0;i<21;i++)
            {
                Console.Write($" {v[i]} ");
            }    

        }
    }
}
