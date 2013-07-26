// Sort 3 real values in descending order using nested if statements.

using System;

class DscendingOrder
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

        // Comparing number one with number two & three
        if (numberOne > numberTwo && numberOne > numberThree)
        {
            if (numberTwo > numberThree)
            {
                Console.WriteLine("{0}, {1}, {2}", numberOne, numberTwo, numberThree);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", numberOne, numberThree, numberTwo);
            }
        }

        // Comparing number two with number one & three
        if (numberTwo > numberOne && numberTwo > numberThree)
        {
            if (numberOne > numberThree)
            {
                Console.WriteLine("{0}, {1}, {2}", numberTwo, numberOne, numberThree);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", numberTwo, numberThree, numberOne);
            }
        }

        // Comparing number three with number one & two
        if (numberThree > numberOne && numberThree > numberTwo)
        {
            if (numberOne > numberTwo)
            {
                Console.WriteLine("{0}, {1}, {2}", numberThree, numberOne, numberTwo);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", numberThree, numberTwo, numberOne);
            }
        }

        // If all the number is with same value
        else
        {
            Console.WriteLine("{0}, {1}, {2}", numberOne, numberTwo, numberThree);
        }
    }
}