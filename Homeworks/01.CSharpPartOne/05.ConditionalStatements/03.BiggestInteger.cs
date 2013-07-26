// Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestInteger
{
    static void Main()
    {
        // Get three numbers
        Console.Write("Enter number one: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter number two: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter number three: ");
        int numberThree = int.Parse(Console.ReadLine());

        // If number one is bigger than number two..
        if (numberOne > numberTwo)
        {
            // If number one is bigger than number three
            if (numberOne > numberThree)
            {
                //.. print number one as biggest number
                Console.WriteLine("The biggest number is number one ({0})", numberOne);
            }
        }

        // Compare number two like number one
        if (numberTwo > numberOne)
        {
            if (numberTwo > numberThree)
            {
                Console.WriteLine("The biggest number is number two ({0})", numberTwo);
            }
        }

        // Compare number three..
        if (numberThree > numberOne)
        {
            if (numberThree > numberTwo)
            {
                Console.WriteLine("The biggest number is number three ({0})", numberThree);
            }
        }

        // If all the number are euqal
        else
        {
            Console.WriteLine("The numbers are equal!");
        }
    }
}
