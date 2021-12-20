using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema50
{
    class Problema50
    {
        static void Main(string[] args)
        {
            int n = 11;
            int[] v = new int[n];
            Random rnd = new Random();
            for(int i=0;i<n;i++)
            {
                v[i] = rnd.Next(200);
            }
            Console.WriteLine("Vectorul este format din");
            for (int i = 0; i < n; i++)
            {
                Console.Write($" {v[i]} ");
            }
            Console.WriteLine();
            if (vectCresc(v,n))
            {
                Console.WriteLine("Vectorul este crescator");
            }
            else
                Console.WriteLine("Vectorul nu este crescator");

            Console.WriteLine($"Valoarea minima din vector este: {vectMin(v,n)}");
            if(vectPar(v,n))
            {
                Console.WriteLine("Vectorul are doar elemente pare.");
            }
            else if(vectImPar(v,n))
                Console.WriteLine("Vectorul are doar elemente impare.");
            else
                Console.WriteLine("Vectorul are elemente mixte.");
            Console.WriteLine($"{rapParImpar(v,n)}");
                
        }

        private static bool vectCresc(int[] v,int n)
        {
           for(int i=0;i<n-1;i++)
            {
                if (v[i] > v[i + 1])
                    return false;
            }
            return true;
        }
        private static int vectMin(int[] v,int n)
        {
            int min = v[0];
            for(int i=1;i<n-1;i++)
            {
                if (v[i] < min)
                    min = v[i];
            }
            return min;

        }
        private static bool vectPar(int[] v,int n)
        {
            for(int i=0;i<n-1;i++)
            {
                if (v[i] % 2 == 1)
                    return false;
            }
            return true;
        }
        private static bool vectImPar(int[] v,int n)
        {
            for (int i = 0; i < n-1; i++)
            {
                if (v[i] % 2 == 0)
                    return false;
            }
            return true;
        }
        private static string rapParImpar(int[] v,int n)
        {
            int nrImp = 0, nrPar = 0,sumImp=0,sumPar=0;
            for(int i=0; i<n;i++)
            {
                if (v[i] % 2 == 0)
                { nrPar++; sumPar += v[i]; }
                else
                { nrImp++; sumImp += v[i]; }
            }
            return $"Exista {nrPar} nr pare si {nrImp} nr impare. Raportul sumelor este {sumPar*1.0 / sumImp}. Raportul nr de elemente pare la impare este: {nrPar*1.0 / nrImp}";

        }
    }
}
