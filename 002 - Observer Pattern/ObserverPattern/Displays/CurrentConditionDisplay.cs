using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    // IS-A Observer en DisplayElement
    // Single responsibility: dit display toont alleen de huidige condities
    internal class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        // Program to an interface: bewaart een Subject, geen WeatherData
        private Subject weatherData;

        public CurrentConditionDisplay(Subject weatherData)
        {
            // Het display meldt zichzelf aan bij het subject
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        // Wordt door WeatherData aangeroepen bij elke nieuwe meting
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Huidige condities: {temperature}°C en {humidity}% luchtvochtigheid.");
        }
    }
}