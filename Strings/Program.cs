using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";
            Console.WriteLine(StringUtils.Reverse(message));

            Console.ReadLine();
        }

    }

    public static class StringUtils
    {
        public static string Reverse(string input)
        {
            char[] text = input.ToCharArray();
            Array.Reverse(text);
            return new string(text);
        }
    }
}
