using System.Security.Cryptography.X509Certificates;
using CSharpFundamentals.Math;
using System;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    public class Person2
    {
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Smith";

            //john.Introduce();

            //Calculator calculator = new Calculator();

            //var result = calculator.add(2, 2);
            //Console.WriteLine(result);

            //var numbers = new int[3];
            //numbers[0] = 1;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;

            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);

            //var names = new string[3] {"Jack", "John", "Mary"};

            //var firstName = "Mosh";
            //var lastName = "Hamedani";

            //var fullName = firstName + " " + lastName;

            //var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            //var names = new string[3] {"John", "Jack", "Mary"};
            //var formattNames = string.Join(", ", names);
            //Console.WriteLine(formattNames);

            //var text = "Hi John \nLook into the following path \nc:\\folder1\\folder2";
            //Console.WriteLine(text);

            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //var methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);

            //Console.WriteLine(method.ToString());

            //var methodName = "Express";
            //var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            //var a = 10;
            //var b = a;
            //b++;

            //Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            //var array1 = new int[3] { 1, 2, 3 };
            //var array2 = array1;

            //array2[0] = 0;

            //Console.WriteLine(string.Format("a: {0}, b: {1}", array1[0], array2[0]));

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person2() {Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person2 person2)
        {
            person2.Age += 10;
        }
    }
}
