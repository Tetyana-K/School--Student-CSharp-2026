using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Navigator
    {
        private IStrategy _strategy; // посилання на клас Стратегії
        public void SetStrategy(IStrategy strategy) // метод  налаштування на певну стратегію
        {
            _strategy = strategy;   
        }
        public void BuildRoute(string from, string to)
        {
            _strategy?.buildRoute(from, to); // викличеться buildRoute() згідно обраної  стратегії
        }
    }
}
