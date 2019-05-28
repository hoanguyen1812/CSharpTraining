using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingWithText
{
    public class StringUtility
    {
        /// <summary>
        ///     Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are
        ///     consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive";
        ///     otherwise, display "Not Consecutive".
        /// </summary>
        public static void Exercise1()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen:");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;
            var numbers = new List<int>();
            var isConsecutive = true;
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
        }

        /// <summary>
        ///     Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter,
        ///     without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display
        ///     "Duplicate" on the console.
        /// </summary>
        public static void Exercise2()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen:");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;
            var numbers = new List<int>();
            var unique = new List<int>();
            var isDuplicate = false;
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            foreach (var number in numbers)
            {
                if (!unique.Contains(number))
                {
                    unique.Add(number);
                }
                else
                {
                    isDuplicate = true;
                }
            }
            if (isDuplicate)
            {
                Console.WriteLine("Duplicate");
            }
        }

        /// <summary>
        ///     Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should
        ///     be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user
        ///     doesn't provide any values, consider it as invalid time.
        /// </summary>
        public static void Exercise3()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00):");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            var time = input.Split(':');
            if (time.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            try
            {
                var hour = Convert.ToInt32(time[0]);
                var minute = Convert.ToInt32(time[1]);
                if (hour >= 0 && hour < 24 && minute >= 0 && minute < 60)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

        /// <summary>
        ///     Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name
        ///     with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that
        ///     the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still
        ///     display "NumberOfStudents".
        /// </summary>
        public static void Exercise4()
        {
            Console.WriteLine("Enter a few words separated by a space: ");
            var input = Console.ReadLine();
            if (input == null)
                return;
            var stringBuilder = new StringBuilder();
            var words = input.Split(' ');
            foreach (var word in words)
            {
                stringBuilder.Append(word.First().ToString().ToUpper() + word.Substring(1).ToLower());
            }
            Console.WriteLine(stringBuilder);
        }

        /// <summary>
        ///     Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
        ///     So, if the user enters "inadequate", the program should display 6 on the console.
        /// </summary>
        public static void Exercise5()
        {
            Console.WriteLine("Enter an English word");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;
            var vowels = new List<char> {'a', 'e', 'o', 'u', 'i'};
            var count = 0;
            foreach (var chr in input)
            {
                if (vowels.Contains(chr))
                    count++;
            }
            Console.WriteLine("Total vowel: " + count);
        }

        public static void Exercise6()
        {
            Console.WriteLine("What's your name?");
            var input = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(input))
                return;
            var length = input.Length;
            var array = new char[length];
            for (int i = input.Length; i > 0; i--)
            {
                array[length - i] = input[i - 1];
            }
            var name = new string(array);
            Console.WriteLine(name);
        }
    }
}