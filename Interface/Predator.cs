using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Predator : Iikan
    {
        public void jenis()
        {
            Console.WriteLine("Contoh Ikan Predator :");
            Console.WriteLine("1. Ikan Arawana");
            Console.WriteLine("2. Ikan Arapaima Gigas");
            Console.WriteLine("3. Ikan Hiu");
        }
    }
}
