using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class RoadStrategy : IStrategy
    {
        public void buildRoute(string from, string to)
        {
            Console.WriteLine($"Road route from {from} to {to}"); 
        }
    }
    internal class WalkingStrategy : IStrategy
    {
        public void buildRoute(string from, string to)
        {
            Console.WriteLine($"Walking route from {from} to {to}"); 
        }
    }
    internal class PublicTransportStrategy : IStrategy
    {
        public void buildRoute(string from, string to)
        {
            Console.WriteLine($"Public transport route from {from} to {to}"); 
        }
    }

}
