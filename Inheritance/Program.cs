using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("Fluffy");
            Console.WriteLine(c1.Speak());

            Dog d1 = new Dog("Spot");
            Console.WriteLine(d1.Speak());

            Console.ReadLine();
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract string Speak();
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public override string Speak()
        {
            return "Meow";
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override string Speak()
        {
            return "Ruff, Ruff";
        }
    }
}
