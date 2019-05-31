using System;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            object name = "Hoa";
            Console.WriteLine(name.GetHashCode().GetHashCode());
        }
    }
}
