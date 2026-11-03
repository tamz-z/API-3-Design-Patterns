using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // IS-A: WeatherData is het Subject
    internal class WeatherData : Subject
    {
        // instance variables
        // HAS-A: een lijst observers. Program to an interface: WeatherData kent geen concrete displays
        // Encapsulation: private, de lijst verandert alleen via Register/Remove
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        // Iedere aangemelde observer krijgt de nieuwe waardes
        public void NotifyObservers()
        {
            foreach (Observer o in observers)
            {
                o.Update(temperature, humidity, pressure);
            }
        }

        // Aanmelden; Contains voorkomt dat een observer dubbel wordt aangemeld
        public void RegisterObserver(Observer o)
        {
            if (!observers.Contains(o))
            {
                observers.Add(o);
            }
        }

        // Afmelden: deze observer krijgt daarna geen updates meer
        public void RemoveObserver(Observer o)
        {
            if (observers.Contains(o))
            {
                observers.Remove(o);
            }
        }

        public float GetTemperature()
        {
            return temperature;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        // Nieuwe meting: state verandert, dus alle observers worden automatisch bijgewerkt
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }
    }
}
