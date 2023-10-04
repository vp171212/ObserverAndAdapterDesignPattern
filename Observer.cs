using ObserverDesignPattern.Model;

namespace ObserverDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            DisplayDevice displayDevice1 = new DisplayDevice("Display 1");
            DisplayDevice displayDevice2 = new DisplayDevice("Display 2");

            weatherStation.RegisterObserver(displayDevice1);
            weatherStation.RegisterObserver(displayDevice2);

            weatherStation.SetMeasurements(26.0f, 60.2f, 1013.2f);
            weatherStation.RemoveObserver(displayDevice1);
            weatherStation.SetMeasurements(28.0f, 50.2f, 1012.2f);
        }
    }
}