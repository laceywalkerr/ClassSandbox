using System;

namespace ClassSandbox
{
    public class Greeter
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}! It's good to see you again");
        }

        public void Greet(Person person)
        {
            Console.WriteLine($"Hey there {person.Name}. Welcome back!");
        }

        public void Greet()
        {
            Console.WriteLine("Welcome Back");
        }
    }
}