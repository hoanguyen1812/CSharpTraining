using System;

namespace Exercise
{
    public class Shipping : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("We are shipping a book");
        }
    }
}