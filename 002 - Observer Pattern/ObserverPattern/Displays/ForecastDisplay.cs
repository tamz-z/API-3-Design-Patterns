using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.Write("Voorspelling: ");

            if (humidity >= 80)
            {
                Console.WriteLine("Het gaat onweren!");
            }
            else if (humidity >= 65 && temperature >= 25)
            {
                Console.WriteLine("Er is kans op onweer.");
            }
            else if (temperature >= 20 && humidity < 65)
            {
                Console.WriteLine("Mooi weer komt er aan!");
            }
            else
            {
                Console.WriteLine("Bewolkt en fris, maar het blijft droog.");
            }
        }
    }
}