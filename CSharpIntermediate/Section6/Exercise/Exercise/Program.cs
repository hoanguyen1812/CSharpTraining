using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var buyABook = new BuyABook();
            buyABook.ShowWorkflow(new Booking());
            buyABook.ShowWorkflow(new Buying());
            buyABook.ShowWorkflow(new Shipping());
        }
    }
}
