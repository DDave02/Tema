using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema41
{
    class Problema41
    {
        static void Main(string[] args)
        {
            int nrmunci, zile_lucrate;
            Console.WriteLine("Dati nr de muncitori: ");
            nrmunci = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati nr de zile care sunt necesare pentru un singur muncitor pentru a termina o lucrare");
            zile_lucrate = int.Parse(Console.ReadLine());
            totZileLucrate(nrmunci, zile_lucrate);

        }
        private static void totZileLucrate(int nrmunci, double zile_lucrate)
        {
            for(int i=1;i<=nrmunci;i++)
            {
                zile_lucrate /= 2.0;
            }
            Console.WriteLine("Numarul de zile lucrate de catre {0} muncitori pentru a termina o lucrare este: {1}",nrmunci,zile_lucrate);

        }
    }
}
