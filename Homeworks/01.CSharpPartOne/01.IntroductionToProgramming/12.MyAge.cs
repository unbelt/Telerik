using System;

namespace MyAge
{
    class MyAge
    {
        static void Main(string[] args)
        {
            int MyAge;
            int MyAgeAfter;

            Console.WriteLine("Enter your age: ");
            MyAge = int.Parse(Console.ReadLine());
            MyAgeAfter = MyAge + 10;

            Console.WriteLine("You are {0} years old!", MyAge);
            Console.WriteLine("You will be {0} years old after ten years.", MyAgeAfter);
        }
    }
}