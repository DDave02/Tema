using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema55
{
    class Problema55
    {
        static void Main(string[] args)
        {
            int n = 21,e=0;
            int[] X = new int[n];
            Random rnd = new Random();
            for(int i=0;i<n;i++)
            {
                X[i] = rnd.Next(300);
                if(i%2==0)
                {
                    e = e + X[i] * (-1);
                }
                else
                {
                    e = e + X[i];
                }
            }
            Console.WriteLine(e);
        }
    }
}
