using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Model
{
    internal class DisplayDevice : IObserver
    {
        string deviceName;
        public DisplayDevice(string name)
        {
            deviceName = name;
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"{deviceName} Display - Temperature: {temperature}C, " +
                $"Humidity: {humidity}%, Pressure: {pressure}hPa");
        }
    }
}
