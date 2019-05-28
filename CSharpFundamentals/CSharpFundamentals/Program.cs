using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Class
            //Person jonh = new Person();
            //jonh.FirstName = "Jonh";
            //jonh.LastName = "Smith";
            //jonh.Introduce();
            //Calculator cal = new Calculator();
            //var result = cal.Add(2, 3);
            //Console.WriteLine(result);

            // Array
            //var numbers = new int[3];
            //numbers[0] = 1;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flag = new bool[3];
            //flag[0] = true;

            //Console.WriteLine(flag[0]);
            //Console.WriteLine(flag[1]);
            //Console.WriteLine(flag[2]);

            //String
            //var firstName = "Jonh";
            //var lastName = "Smith";

            //Enums
            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //var methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);

            //var methodName = "Express";
            //var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() {Age = 1};
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}