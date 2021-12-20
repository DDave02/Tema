using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema47
{
    class Problema47
    {
        static void Main(string[] args)
        {
            int[] v = new int[101];
            int[] vf = new int[101];
            Console.WriteLine("Dati 100 de numere: ");
            for(int i=0;i<101 ; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tabloul creat este: ");
            for(int i=0;i<101;i++)
            {
                Console.Write($" {v[i]} ");
            }
            for(int i=0;i<101;i++)
            {
                for(int j=0;j<101;j++)
                    if(i!=j) 
                        if(v[i]==v[j]) 
                            vf[v[i]]++;
            }
            Console.WriteLine("Numerele care se repeta sunt: ");
            for(int i=0;i<=100;i++)
            {
                if (vf[i] != 0)
                    Console.Write($" {i} ");
            }
        }
    }
}
