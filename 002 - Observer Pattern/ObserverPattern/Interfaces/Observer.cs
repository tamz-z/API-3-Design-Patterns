using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    // Observer: iedereen die een seintje wil bij een verandering (de "abonnee")
    // Push-model: het subject stuurt alle waardes mee
    internal interface Observer
    {
        void Update(float temp, float humidity, float pressure);
    }
}
