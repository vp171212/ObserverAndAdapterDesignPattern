using AdapterDesignPattern.Model;

namespace AdapterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OldPrinter oldPrinter = new OldPrinter();
            UsbAdapter usbAdapter = new UsbAdapter(oldPrinter);
            SmartPhone smartPhone = new SmartPhone(); 
            smartPhone.Print(usbAdapter);
            Console.ReadKey();
        }
    }
}