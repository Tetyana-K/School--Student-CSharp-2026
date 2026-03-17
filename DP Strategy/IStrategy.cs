using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal interface IStrategy
    {
        void buildRoute(string from, string to);
    }
}
