using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class ModernCoffeeTable : ICoffeTable
    {
        public void DrinkCoffe()
        {
            Console.WriteLine("You can drink coffee at cool modern table"); 
        }

        public void EatCookies()
        {
            Console.WriteLine("You can eat cookies at cool modern table"); 
            
        }
    }
    internal class ClassicCoffeeTable : ICoffeTable
    {
        public void DrinkCoffe()
        {
            Console.WriteLine("You can drink coffee at nice classic table"); 
        }

        public void EatCookies()
        {
            Console.WriteLine("You can eat cookies at nice classic table"); 
            
        }
    }
}
