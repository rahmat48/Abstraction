using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstrakClass
{
    public class Hias : Ikan
    {
        public override void Jenis()
        {
            Console.WriteLine("Karakteristik Ikan Hias");
            Console.WriteLine("1. Memiliki bentuk fisik yang indah");
            Console.WriteLine("2. Makanan biasanya mengandung vitamin yang tinggi");
            Console.WriteLine("3. Rata-rata sering untuk kontes/tournament");
            Console.WriteLine();
        }
    }
}
