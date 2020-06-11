using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstrakClass
{
    public class Predator : Ikan
    {
        public override void Jenis()
        {
            Console.WriteLine("Karakteristik Ikan Predator");
            Console.WriteLine("1. Memiliki gigi yang tajam");
            Console.WriteLine("2. Karnivora (Pemakan Daging)");
            Console.WriteLine("3. Rata-rata memiliki umur yang panjang");
            Console.WriteLine();
        }
    }
}
