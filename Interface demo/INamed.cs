using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    internal interface INamed
    {
        string Name { get; set; } // неявно абстрактна властивість, яка має бути реалізована у похідних типах( класах, структурах)
    }
}
