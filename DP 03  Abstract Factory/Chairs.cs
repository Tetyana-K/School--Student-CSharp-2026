using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class ModernChair : IChair
    {
        public bool HasLegs()
        {
            return false; // немає ніжок у ModernChair стільця
        }

        public void SitOn()
        {
            Console.WriteLine("You can sit in modern and comportable chair");
        }
    }
    internal class ClassicChair : IChair
    {
        public bool HasLegs()
        {
            return true;
        }

        public void SitOn()
        {
            Console.WriteLine("You can sit in classic chair");
        }
    }
}
