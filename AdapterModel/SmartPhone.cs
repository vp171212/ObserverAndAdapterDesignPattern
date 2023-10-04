using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Model
{
    internal class SmartPhone
    {
        public void Print(IUsbTypeC usbDevice)
        {
            Console.WriteLine("Connecting with USB Type-C device.");
            usbDevice.PrintWithUsbTypeC();
        }
    }
}
