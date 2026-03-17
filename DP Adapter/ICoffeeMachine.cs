using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal interface ICoffeeMachine // інтерфейс, який необхідний клієнту
    {
        void MakePureCoffe();
        void MakeLatte();
    }
}
