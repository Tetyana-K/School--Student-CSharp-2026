using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // клас адаптеру старого класу під новий інтерфейс
    internal class CoffeMachine : ICoffeeMachine
    {
        private DrinkMachine drinkMachine = new DrinkMachine(); // посилання на обєкт старого класу (потрібного нам сервісу)
        public void MakeLatte()
        {
            Console.WriteLine("Making latte...");
            drinkMachine.MakeCofee();
            drinkMachine.MakeHotMilk();
        }

        public void MakePureCoffe()
        {
            Console.WriteLine("Making pure coffee...");
            drinkMachine.MakeCofee();
        }
    }
}
