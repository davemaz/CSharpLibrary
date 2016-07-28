using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // built in types
            byte b1 = 255;
            char c1 = 'a';
            bool b2 = true;
            sbyte s1 = 127;
            ushort u1 = 65535;
            int i1 = 2147483647;
            uint u2 = 4294967295;
            float f1 = 1234.1234567f;
            double d1 = 1234.123456789;
            decimal d2 = 10.99m;
            long l1 = 9223372036854775807;
            ulong u3 = 123456789;

            Console.WriteLine($"{b1.GetType()}, \nMin: {byte.MinValue}, Max: {byte.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"{c1.GetType()}, \nMin: {char.MinValue}, Max: {char.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"{b2.GetType()}, Value: {b2}");
            Console.WriteLine();
            Console.WriteLine($"{s1.GetType()}, \nMin: {sbyte.MinValue}, Max: {sbyte.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"{u1.GetType()}, \nMin: {ushort.MinValue}, Max: {ushort.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"{i1.GetType()}, \nMin: {int.MinValue}, Max: {int.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"{u2.GetType()}, \nMin: {uint.MinValue}, Max: {uint.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"{f1.GetType()}, \nMin: {float.MinValue}, Max: {float.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"{d1.GetType()}, \nMin: {double.MinValue}, Max: {double.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"{d2.GetType()}, \nMin: {decimal.MinValue}, Max: {decimal.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"{l1.GetType()}, \nMin: {long.MinValue}, Max: {long.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"{u3.GetType()}, \nMin: {ulong.MinValue}, Max: {ulong.MaxValue}");

            Console.ReadLine();
        }
    }
}
