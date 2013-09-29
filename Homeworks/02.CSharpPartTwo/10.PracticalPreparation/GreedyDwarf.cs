using System;
using System.Collections.Generic;
// http://bgcoder.com/Contest/Practice/92

class GreedyDwarf
{
    static int[] ProcessInput(string[] input)
    {
        var output = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            output[i] = int.Parse(input[i].ToString());
        }

        return output;
    }

    static void Main()
    {
        var valleyInput = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        var valley = ProcessInput(valleyInput);

        int patterns = int.Parse(Console.ReadLine());

        long coins = 0;
        long maxCoins = long.MinValue;

        int currentPosition = 0;
        int nextPosition = 0;

        for (int i = 0; i < patterns; i++)
        {
            var patternInput = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var pattern = ProcessInput(patternInput);

            var visited = new bool[valley.Length];

            coins = valley[0];
            visited[0] = true;

            int index = 0;

            while (true)
            {
                nextPosition = currentPosition + pattern[index];

                if (nextPosition < valley.Length && nextPosition >= 0 && !visited[nextPosition])
                {
                    coins += valley[nextPosition];
                    currentPosition = nextPosition;
                    visited[nextPosition] = true;
                    index++;
                }
                else
                {
                    currentPosition = 0;
                    break;
                }

                if (index == pattern.Length)
                {
                    index = 0;
                }
            }

            if (coins > maxCoins)
            {
                maxCoins = coins;
            }
        }

        Console.WriteLine(maxCoins);
    }
}