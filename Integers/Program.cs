using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = int.MinValue;

            Console.WriteLine($"int Type: {i.GetType()}");
            Console.WriteLine($"int minimum value: {i}");

            i = int.MaxValue;

            Console.WriteLine($"int maximum value: {i}");

            Console.ReadLine();
        }
    }
}
