using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class ManualBuilder : IBuilder
    {
        private Manual _manual;
        public void MakeEngine(int power)
        {
            _manual.AddText($"Set engine  with  power {power}\n");
        }

        public void MakeSeats(int seats)
        {
            _manual.AddText($"Set {seats} seats\n");
        }

        public void Reset()
        {
            _manual = new Manual();
            _manual.AddText($"Start of building\n");
        }
        public Manual GetResult()
        {
            return _manual;
        }
    }
}
