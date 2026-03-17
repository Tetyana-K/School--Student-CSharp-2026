using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal interface IFurnitureFactory // інтерфейс для Абстрактної Фабрики
    {
        IChair CreateChair();
        ICoffeTable CreateCoffeTable();
    }
}
