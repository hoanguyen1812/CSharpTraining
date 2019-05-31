using System.Runtime.InteropServices;
using System;

namespace LambdaExpressions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(5));
            var books= new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(a => a.Price < 300);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}