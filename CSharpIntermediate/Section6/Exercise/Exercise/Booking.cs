using System;

namespace Exercise
{
    public class Booking : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("We are booking a book");
        }
    }
}