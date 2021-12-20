using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema40
{
    class Problema40
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati viteza unui obiect in km/h");

            double km=int.Parse(Console.ReadLine()), h=1;
            double[] vkms = {km,h};
            double[] vms = { 0, 0 };
            vms[0] = vkms[0] * 1000;
            vms[1] = vkms[1] * 3600;
            Console.WriteLine($"Viteza transformata este {Math.Round(vms[0]/vms[1],2)} m/s.");
        }
    }
}
