using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Konsumsi : Iikan
    {
        public void jenis()
        {
            Console.WriteLine("Contoh Ikan Konsumsi :");
            Console.WriteLine("1. Ikan Tuna");
            Console.WriteLine("2. Ikan Nila");
            Console.WriteLine("3. Ikan Lele");
        }
    }
}
