using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class Client
    {
        private IFurnitureFactory factory; // посилання на Абстрактну Фабрику
        
        private List<IChair> chairs = new List<IChair>();
        private ICoffeTable coffeTable; 
        public Client(IFurnitureFactory factory) // у конструктор прийде посилання на Конкретну фабрику
        {
            this.factory = factory;
        }

        public void CreateFurniture(int numOfChairs = 1)
        {
            if (factory == null)
                return;
            coffeTable = factory.CreateCoffeTable();
            for (int i = 0; i < numOfChairs; i++)
            {
                chairs.Add(factory.CreateChair()); 
            }
        }
        public void PrintFurnitures()
        {
            if (coffeTable == null)
            {
                Console.WriteLine("You must create furnitures first");
                return;
            }
            coffeTable.DrinkCoffe();
            coffeTable.EatCookies();
            Console.WriteLine();
            for (int i = 0; i < chairs.Count; i++)
            {
                Console.WriteLine($"Chair  # {i + 1} Has legs : {chairs[i].HasLegs()}");
                chairs[i].SitOn();
            }
        }
    }
}
