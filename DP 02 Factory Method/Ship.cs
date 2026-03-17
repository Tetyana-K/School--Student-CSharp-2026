using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class Ship : ITransport // клас Корабель реалізує інтерфейс Транспорту
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by ship");
        }
    }
}
