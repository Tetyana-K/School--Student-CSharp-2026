using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        private IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }
        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }
        public void MakeSportCar()
        {
            _builder.Reset();
            _builder.MakeSeats(2);
            _builder.MakeEngine(7);
        }
        public void MakeSUVCar()
        {
            _builder.Reset();
            _builder.MakeSeats(4);
            _builder.MakeEngine(5);
        }
    }
}
