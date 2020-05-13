using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface
{
    public class Canon : IPrinter
    {

        public void show(Printer printer)
        {
            Console.WriteLine("Canon Display Dimension : 9.5*12");
        }

        public void print(Printer printer)
        {
            Console.WriteLine("Canon Printer Printing......");
        }
    }
}
