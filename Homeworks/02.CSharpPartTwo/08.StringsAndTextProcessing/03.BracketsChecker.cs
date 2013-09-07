using System;
// Write a program to check if in a given input the brackets are put correctly.
// Example of correct input: ((a+b)/5-d).
// Example of incorrect input: )(a+b)).

class BracketsChecker
{
    static void Main()
    {
        Console.Write("Enter an input: ");
        string input = Console.ReadLine();

        int bracket = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                bracket++;
            }
            else if (input[i] == ')')
            {
                bracket--;
            }
        }

        if (bracket == 0)
        {
            Console.WriteLine("{0} -> Correct input", input);
        }
        else
        {
            Console.WriteLine("{0} -> Incorrect input", input);
        }
    }
}