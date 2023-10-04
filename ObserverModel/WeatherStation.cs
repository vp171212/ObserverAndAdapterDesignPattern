using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Model
{
    internal class WeatherStation : ISubject
    { List<IObserver> observers = new List<IObserver>();
        float temperature;
        float humidity;
        float pressure;
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

       

        public void SetMeasurements(float temperature,float humidity,float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }

        private void MeasurementChanged()
        {
            NotifyObservers();
        }
    }
}
