using System;
// http://bgcoder.com/Contest/Practice/94

class JoroTheRabbit
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputNumber = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var numbers = new int[inputNumber.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(inputNumber[i]);
        }

        int bestPath = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 1; j < numbers.Length; j++)
            {
                int index = i;
                int currnetPath = 1;
                int next = index + j;

                if (next >= numbers.Length)
                {
                    next = next - numbers.Length;
                }

                while (numbers[index] < numbers[next])
                {
                    currnetPath++;
                    index = next;
                    next = (index + j) % numbers.Length;
                }

                if (bestPath < currnetPath)
                {
                    bestPath = currnetPath;
                }
            }
        }

        Console.WriteLine(bestPath);
    }
}