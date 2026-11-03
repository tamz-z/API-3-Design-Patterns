using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.FlyBehavior
{
    // Identify what varies: vliegen verschilt per eend, dus het staat los van Duck
    // Open/closed: nieuw vlieggedrag = nieuwe class, Duck blijft ongewijzigd
    internal interface FlyBehavior
    {
       public void Fly();

    }
}
