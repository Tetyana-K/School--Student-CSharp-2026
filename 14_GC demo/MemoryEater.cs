using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_GC_demo
{
    internal class MemoryEater
    {
        int[] arr;
        static int lastId = 0;
        public readonly int Id = ++lastId;
        public MemoryEater(int size = 10000)
        {
            arr = new int[size];
            Console.WriteLine($"Object # {Id} created");
        }
        ~MemoryEater() // finalizer, 
        {
            Console.WriteLine($"\t\tObject # {Id} finalized");
        }

    }
}
