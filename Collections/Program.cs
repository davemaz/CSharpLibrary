using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<char> s = new Stack<char>();
            s.Push('A');
            s.Push('B');
            s.Push('C');

            Console.WriteLine("Current Stack:");
            foreach(char c in s)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine($"Next in stack: {s.Peek()}");

            s.Push('D');

            Console.WriteLine($"Next in stack: {s.Peek()}");

            char letter = s.Pop();
            Console.WriteLine($"Popped: {letter}");
            s.Pop();


            Console.WriteLine("Current stack: ");
            foreach (char c in s)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Console.WriteLine("Current Queue:");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Next in queue: {q.Peek()}");

            q.Enqueue(4);

            Console.WriteLine($"Next in queue: {q.Peek()}");

            var num = q.Dequeue();
            Console.WriteLine($"Dequeued: {num}");
            q.Dequeue();

            Console.WriteLine("Current Queue:");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
