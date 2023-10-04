using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Model
{
    internal class OldPrinter
    {
        public void PrintWithUsbA()
        {
            Console.WriteLine("Printing with USB-A");
        }
    }
}
