using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Problema18
{
    class Problema18
    {
        static void Main(string[] args)
        {
            //initializare date si SoundPlayer
            SoundPlayer player = new SoundPlayer("error.wav");
            Console.WriteLine("Dati doua numere pe randuri diferite: ");
            int a, b;
            a= int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int[] v = { a, b };
            int x;
            Console.WriteLine("Ce doriti sa calculam?");
            Console.WriteLine("Media aritmetică (1) sau geometrică (2)?");
            //In caz daca X este numar audioul va fi pornit
            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                player.Load();
                player.Play();
                Console.ReadKey();
                throw;
            }
            //rezolvarea in sine
            if(x==1 || x==2)
            {
                if(x==1)
                    Console.WriteLine($"Media aritmetica a numerelor este: {v.Average()}.");
                if (x == 2)
                    if((v[0]>=0 && v[1]>=0) || (v[0]<=0 && v[1]<=0))
                    {
                        Console.WriteLine($"Media geometrica a numerelor este {Math.Sqrt(v[0] * v[1])}");
                    }
                    else
                        Console.WriteLine("Eroare!");

            }
            //in caz daca x este diferit de 1 sau 2 audioul va fi pornit
            else
            {
                player.Load();
                player.Play();
                Console.ReadKey();
            }
        }
    }
}
