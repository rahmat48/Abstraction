using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstrakClass
{
    public class Konsumsi : Ikan
    {
        public override void Jenis()
        {
            Console.WriteLine("Karakteristik Ikan Konsumsi");
            Console.WriteLine("1. Jumlah atau populasinya sangat banyak");
            Console.WriteLine("2. Makanan mengandung vitamin untuk pertumbuhan");
            Console.WriteLine("3. Rata-rata memiliki umur yang pendek");
            Console.WriteLine();
        }
    }
}
