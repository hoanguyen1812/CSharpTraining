using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var person = new Person(DateTime.Now);
            Console.WriteLine(person.Age);
        }
    }
}
