using System;

namespace Conditionals
{
    internal class Program
    {
        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Choose an exercise from 1 to 4: ");
            var input = Console.ReadLine();
            var pr = new Program();
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
                default:
                    Console.WriteLine("Invalid exercise!");
                    break;
            }
        }

        /// <summary>
        ///     Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a
        ///     valid number, display "Valid" on the console. Otherwise, display "Invalid".
        /// </summary>
        public void Exercise1()
        {
            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number > 0 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        /// <summary>
        ///     Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public void Exercise2()
        {
            Console.WriteLine("x = ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y = ");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The greater number is {0}", x > y ? x : y);
        }

        /// <summary>
        ///     Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or
        ///     portrait.
        /// </summary>
        public void Exercise3()
        {
            Console.WriteLine("Enter width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            var height = Convert.ToInt32(Console.ReadLine());
            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("The image is {0}", orientation);
        }

        /// <summary>
        ///     Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc
        ///     and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program
        ///     asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the
        ///     console. If the value is above the speed limit, the program should calculate the number of demerit points. For
        ///     every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number
        ///     of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        public void Exercise4()
        {
            Console.WriteLine("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of a car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                const int kmPerDetermitPoint = 5;
                var determitPoints = (carSpeed - speedLimit)/kmPerDetermitPoint;
                if (determitPoints < 12)
                {
                    Console.WriteLine(determitPoints);
                }
                else
                {
                    Console.WriteLine("License Syspended");
                }
            }
        }
    }
}