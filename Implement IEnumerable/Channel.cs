using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_realiz
{
    class Channel
    {
        public string? Name { get; set; }
        public int Number { get; set; }
        public override string ToString()
        {
            return $"Channel # {Number, -3} :: {Name, -10}";
        }
    }
}
