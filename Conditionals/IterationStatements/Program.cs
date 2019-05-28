using System;

namespace IterationStatements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var isExit = false;
                var pr = new Program();
                Console.WriteLine("Choose an exercise from 1 to 5 or press any key to exit:");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        pr.Exercise1();
                        break;
                    case "2":
                        pr.Exercise2();
                        break;
                    case "3":
                        pr.Exercise3();
                        break;
                    case "4":
                        pr.Exercise4();
                        break;
                    case "5":
                        pr.Exercise5();
                        break;
                    default:
                        isExit = true;
                        break;
                }
                if (isExit)
                {
                    break;
                }
            }
        }

        /// <summary>
        ///     Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count
        ///     on the console.
        /// </summary>
        public void Exercise1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                    count++;
            }
            Console.WriteLine($"{count} numbers divisible by 3 with no remainder");
        }

        /// <summary>
        ///     Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the
        ///     previously entered numbers and display it on the console.
        /// </summary>
        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                var input = Console.ReadLine();
                if (input != "ok")
                {
                    var number = Convert.ToInt32(input);
                    sum += number;
                }
                else break;
            }
            Console.WriteLine($"Sum of all number: {sum}");
        }

        /// <summary>
        ///     Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the
        ///     console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! =
        ///     120.
        /// </summary>
        public void Exercise3()
        {
            var result = 1;
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            for (var i = number; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine($"{number}! = {result}");
        }

        /// <summary>
        ///     Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the
        ///     user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving
        ///     correctly, you can display the secret number on the console first.)
        /// </summary>
        public void Exercise4()
        {
            const int chance = 4;
            var random = new Random();
            var number = random.Next(1, 10);
            var result = false;
            for (var i = 0; i < chance; i++)
            {
                Console.WriteLine("Please guess a number: ");
                var inputNumber = Convert.ToInt32(Console.ReadLine());
                if (inputNumber == number)
                {
                    result = true;
                    break;
                }
            }
            Console.WriteLine(result ? "You won the number is {0}" : "You lost the number is {0}", number);
        }

        /// <summary>
        ///     Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers
        ///     and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        /// </summary>
        public void Exercise5()
        {
            Console.WriteLine("Enter a series of numbers separated by comma:");
            var input = Console.ReadLine();
            if (input != null)
            {
                var numbers = input.Split(',');
                var max = Convert.ToInt32(numbers[0]);
                foreach (var chr in numbers)
                {
                    var number = Convert.ToInt32(chr);
                    if (number > max)
                        max = number;
                }
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}