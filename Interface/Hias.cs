using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Hias : Iikan
    {
        public void jenis()
        {
            Console.WriteLine("Contoh Ikan Hias :");
            Console.WriteLine("1. Ikan Koi");
            Console.WriteLine("2. Ikan Mas");
            Console.WriteLine("3. Ikan Cupang");
        }
    }
}

