using System;

namespace Exercise
{
    public class Buying : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("We are buying a book");
        }
    }
}