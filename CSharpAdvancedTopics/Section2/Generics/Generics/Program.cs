namespace Generics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(1);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<int, Book>();
            dictionary.Add(1, new Book());
        }
    }
}