using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Structs.Point(10, 10);
            Point p2 = new Structs.Point();

            Console.WriteLine($"p1: {p1}");

            // Struct members are always initialized to their default values (int = 0)
            Console.WriteLine($"p2: {p2}");

            p2.X = 5;
            p2.Y = 10;
            Console.WriteLine($"p2: {p2}");

            Console.ReadLine();
        }
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int p1, int p2)
        {
            X = p1;
            Y = p2;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
