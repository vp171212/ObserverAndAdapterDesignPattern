using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Model
{
    internal class UsbAdapter : IUsbTypeC
    {
        private OldPrinter oldPrinter;

        public UsbAdapter(OldPrinter printer)
        {
            oldPrinter = printer;
        }
        public void PrintWithUsbTypeC()
        {
            oldPrinter.PrintWithUsbA();
        }
    }
}
