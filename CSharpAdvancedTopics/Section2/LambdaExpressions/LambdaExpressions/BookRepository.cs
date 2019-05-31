using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Title = "Title 1", Price = 100},
                new Book {Title = "Title 2", Price = 200},
                new Book {Title = "Title 3", Price = 300}
            };
        }
    }
}