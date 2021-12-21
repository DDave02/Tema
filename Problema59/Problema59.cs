using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema59
{
    class Problema59
    {
        static void Main(string[] args)
        {
            int poz=3;
            int[] v= { 1,3,5,7,9,11,12 };
           for(int i=poz;i<v.Length-1;i++)
            {
                    v[i] = v[i + 1];
            }
           
           for(int i=0; i<v.Length-1; i++)
                Console.Write($" {v[i]} ");
        }
    }
}
