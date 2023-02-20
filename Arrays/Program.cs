using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linklist = new LinkedList<int>();
            linklist.AddLast(3);
            linklist.AddFirst(5);

            Console.WriteLine(linklist);
            foreach (var i in linklist)
            {
                Console.WriteLine(i);
            }

        }
    }
}
