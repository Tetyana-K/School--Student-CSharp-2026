using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // клас Сервісу з  корисним функціоналом, який хочемо  перевикористати для  нового клієнту на новому інтерфейсі 
    internal class DrinkMachine
    {
        public void MakeCofee()
        {
            Console.WriteLine("Make coffee");
        }
        public void MakeTea()
        {
            Console.WriteLine("Make tea");
        }
        public void MakeHotMilk()
        {
            Console.WriteLine("Make hot milk");
        }

    }
}
