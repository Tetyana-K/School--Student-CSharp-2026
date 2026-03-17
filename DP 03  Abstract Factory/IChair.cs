using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal interface IChair // інтерфейс для всіх  продуктів виду Стілець
    {
        bool HasLegs();
        void SitOn();
    }
}
