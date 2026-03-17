using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface IBuilder
    {
        void Reset();
        void MakeSeats(int seats);
        void MakeEngine(int power);
    }
}
