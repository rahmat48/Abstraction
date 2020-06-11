using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.AbstrakClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Ikan ikan;
            Iikan ikan2;

            Console.WriteLine("Pilih Jenis Informasi Ikan");
            Console.WriteLine("1. Ikan Predator");
            Console.WriteLine("2. Ikan Hias");
            Console.WriteLine("3. Ikan Konsumsi");
            Console.WriteLine("");
            Console.WriteLine("Jenis Ikan [1..3] : ");
            int nomor = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            if (nomor == 1)
            {
                ikan = new AbstrakClass.Predator();
                ikan.Jenis();
                ikan2 = new Interface.Predator();
                ikan2.jenis();
            }
            else if (nomor == 2)
            {
                ikan = new AbstrakClass.Hias();
                ikan.Jenis();
                ikan2 = new Interface.Hias();
                ikan2.jenis();
            }
            else if (nomor == 3)
            {
                ikan = new AbstrakClass.Konsumsi();
                ikan.Jenis();
                ikan2 = new Interface.Konsumsi();
                ikan2.jenis();
            }
            else
            {
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
