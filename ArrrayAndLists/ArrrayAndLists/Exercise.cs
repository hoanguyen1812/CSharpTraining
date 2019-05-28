using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrrayAndLists
{
    public class Exercise
    {
        /// <summary>
        ///     When you post a message on Facebook, depending on the number of people who like your post, Facebook displays
        ///     different information.
        ///     - If no one likes your post, it doesn't display anything.
        ///     - If only one person likes your post, it displays: [Friend's Name] likes your post.
        ///     - If two people like your post, it displays: [Friend 1]
        ///     and[Friend 2] like your post.
        ///     - If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others
        ///     like
        ///     your post.
        ///     Write a program and continuously ask the user to enter different names, until the user presses Enter (without
        ///     supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        /// </summary>
        public void Exercise1()
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter name: ");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                names.Add(input);
            }
            switch (names.Count)
            {
                case 0:
                    Console.WriteLine("No one like your post");
                    break;
                case 1:
                    Console.WriteLine(names[0] + "likes your post");
                    break;
                case 2:
                    Console.WriteLine($"{names[0]}, {names[1]} like your post");
                    break;
                default:
                    Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post");
                    break;
            }
        }

        /// <summary>
        ///     Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in
        ///     a new string. Display the reversed name on the console.
        /// </summary>
        public void Exercise2()
        {
            Console.WriteLine("Enter your name: ");
            var input = Console.ReadLine();
            if (input == null) return;

            var names = new string[input.Length];

            for (var i = 0; i < input.Length; i++)
            {
                names[i] = input[i].ToString();
            }
            Array.Reverse(names);
            Console.WriteLine(names);
        }

        /// <summary>
        ///     Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error
        ///     message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the
        ///     result on the console.
        /// </summary>
        public void Exercise3()
        {
            var i = 0;
            const int totalNumber = 5;
            var numbers = new int[totalNumber];
            while (i < totalNumber)
            {
                Console.WriteLine("Enter a number: ");
                var val = Convert.ToInt32(Console.ReadLine());
                if (Array.IndexOf(numbers, val) != -1)
                    continue;
                numbers[i] = val;
                i++;
            }
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        ///     Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may
        ///     include duplicates. Display the unique numbers that the user has entered.
        /// </summary>
        public void Exercise4()
        {
            var numbers = new List<string>();
            while (true)
            {
                Console.WriteLine(@"Enter a number or type 'Quit' to exit");
                var input = Console.ReadLine();
                if (input == "Quit")
                    break;
                if (numbers.Contains(input) || string.IsNullOrEmpty(input))
                    continue;
                numbers.Add(input);
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        ///     Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is
        ///     empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3
        ///     smallest numbers in the list.
        /// </summary>
        public void Exercise5()
        {
            var numbers = new List<int>();
            Console.WriteLine("Supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10): ");
            var input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Invalid List");
                return;
            }

            var inputNumbers = input.Split(',');
            foreach (var number in inputNumbers)
            {
                numbers.Add(Convert.ToInt32(number));
            }
            if (numbers.Count < 5)
            {
                Console.WriteLine("Invalid List");
            }
            else
            {
                numbers.Sort();
                var smallestNumber = numbers.Take(3);
                foreach (var number in smallestNumber)
                {
                    Console.Write(number+ " ");
                }
            }
            Console.WriteLine();
        }
    }
}