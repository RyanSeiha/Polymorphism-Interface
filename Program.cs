using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet \n");

            Console.Write("Pilih Berdasarkan Nomer Printer : ");
            int NoPrinter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            IPrinter ptr;

            if (NoPrinter == 1)
            {
                ptr = new Epson();
            }
            else if (NoPrinter == 2)
            {
                ptr = new Canon();
            }
            else
            {
                ptr = new LaserJet();
            }

            ptr.show(printer);
            ptr.print(printer);

            Console.ReadKey();
        }
    }
}
