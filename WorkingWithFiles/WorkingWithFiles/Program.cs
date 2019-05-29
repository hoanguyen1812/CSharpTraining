using System;
using System.IO;

namespace WorkingWithFiles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
        }

        /// <summary>
        ///     Write a program that reads a text file and displays the number of words.
        /// </summary>
        private static void Exercise1()
        {
            var path = @"D:\Learning\C#\Utility\Ex1.txt";
            var content = File.ReadAllText(path);
            var words = content.Split(' ');
            Console.WriteLine(words.Length);
        }

        /// <summary>
        ///     Write a program that reads a text file and displays the longest word in the file.
        /// </summary>
        private static void Exercise2()
        {
            var path = @"D:\Learning\C#\Utility\Ex1.txt";
            var content = File.ReadAllText(path);
            var words = content.Split(' ');
            var max = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (max.Length < words[i].Length)
                    max = words[i];
            }
            Console.WriteLine(max);
        }
    }
}