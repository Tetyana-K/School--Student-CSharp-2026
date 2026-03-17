using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal interface ITransport // інтерфейс для видів транспорту, кожен транспорт повинен мати метод Доставка
    {
        void Deliver();
    }
}
