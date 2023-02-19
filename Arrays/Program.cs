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
            Arrays<int> arr = new Arrays<int>(2);

            arr.Insert(2);
            arr.Insert(3);
            arr.Insert(5);
            arr.Insert(6);
            arr.Insert(8);
            arr.Remove(9);
            Console.WriteLine(arr.IndexOf(3));
            arr.Print();
        }
    }
}
