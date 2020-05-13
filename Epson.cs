using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface
{
    public class Epson : IPrinter
    {


        public void show(Printer printer)
        {
            Console.WriteLine("Epson Display Dimension : 10*11");
        }

        public void print(Printer printer)
        {
            Console.WriteLine("Epson Printer Printing......");
        }
    }
}
