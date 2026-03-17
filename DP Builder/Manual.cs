using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Manual
    {
        private string _manual = String.Empty;
        public void AddText(string text)
        {
            _manual += text;
        }
        public string Info => _manual;
    }
}
