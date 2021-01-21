using System;
using System.Collections.Generic;

namespace Farm
{
    public class StartUp
    {
        public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("eating...");
            }
        }
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("barking...");
            }
        }
        public class Puppy : Dog
        {
            public void Weep()
            {
                Console.WriteLine("weeping...");
            }
        }
        public class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine("meowing...");
            }
        }
    }
}

namespace CustomRandomList
{
    public class StartUp
    {
        public class RandomList : List<string>
        {
            private readonly Random random = new Random();
            public string RemoveRandomString()
            {
                int index = random.Next(0, this.Count);

                string str = this[index];
                this.RemoveAt(index);

                return str;
            }
        }
    }
}

namespace CustomStack
{
    public class StartUp
    {
        public class StackOfStrings : Stack<string>
        {
            public bool IsEmpty()
            {
                return this.Count == 0;
            }
            public void AddRange(IEnumerable<string> collection)
            {
                foreach (var element in collection)
                {
                    this.Push(element);
                }
            }
        }
    }
}

namespace W2._1Inheritance.Lab
{
    public class Program
    {
        // static void Main()
        // {
        //     var app = new StackOfStrings();

        //     app.Run();

        //     Console.ReadKey(true);
        // }
    }
    public class SingleInheritance
    {
        public void Run()
        {
            var dog = new Farm.StartUp.Dog();
            dog.Bark();
            dog.Eat();
        }
    }
    public class MultipleInheritance
    {
        public void Run()
        {
            var puppy = new Farm.StartUp.Puppy();

            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
    public class HierarchicalInheritance
    {
        public void Run()
        {
            var dog = new Farm.StartUp.Dog();
            dog.Eat();
            dog.Bark();

            var cat = new Farm.StartUp.Cat();
            cat.Eat();
            cat.Meow();
        }
    }
    public class RandomList
    {
        public void Run()
        {
            var list = new CustomRandomList.StartUp.RandomList();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i.ToString());
            }

            System.Console.WriteLine(list.RemoveRandomString());
        }
    }
    public class StackOfStrings
    {
        public void Run()
        {
            var stack = new CustomStack.StartUp.StackOfStrings();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i.ToString());
            }

            if (stack.IsEmpty())
                System.Console.WriteLine("Stack is empty!");
            else
                System.Console.WriteLine("Stack has {0} element(s)!", stack.Count);

            string[] array = { "11", "13", "15", "17" };

            stack.AddRange(array);
            
            System.Console.WriteLine("Stack has been added {0} element(s)!", array.Length);
        }
    }
}
