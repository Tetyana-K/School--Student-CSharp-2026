using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class ModernFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new ModernCoffeeTable();
        }
    }
    internal class ClassicFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ClassicChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new ClassicCoffeeTable();
        }
    }
}
