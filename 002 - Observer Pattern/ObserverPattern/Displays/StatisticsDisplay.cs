using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;

            // Bij de eerste meting zijn max en min gelijk aan die meting,
            // anders zou de startwaarde 0 het minimum blijven.
            if (countUpdated == 0)
            {
                maxTemp = temp;
                minTemp = temp;
            }
            else
            {
                if (temp > maxTemp) maxTemp = temp;
                if (temp < minTemp) minTemp = temp;
            }

            sumTemperature += temp;
            countUpdated++;

            Display();
        }

        public void Display()
        {
            if (countUpdated == 0)
            {
                Console.WriteLine("Statistieken: nog geen metingen ontvangen.");
                return;
            }

            float average = sumTemperature / countUpdated;
            Console.WriteLine($"Statistieken: gemiddelde {average:F1}°C / maximum {maxTemp}°C / minimum {minTemp}°C (over {countUpdated} metingen).");
        }
    }
}