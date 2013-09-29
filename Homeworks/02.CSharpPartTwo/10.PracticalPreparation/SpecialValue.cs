using System;
// http://bgcoder.com/Contest/Practice/95

class SpecialValue
{
    static int[][] ProcessInput(int[][] input)
    {
        for (int i = 0; i < input.GetLength(0); i++)
        {
            string[] currentLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            input[i] = new int[currentLine.Length];

            for (int j = 0; j < currentLine.Length; j++)
            {
                input[i][j] = int.Parse(currentLine[j]);
            }
        }

        return input;
    }

    static long FindSpecialValue(int[][] field, int col, bool[][] visited)
    {
        long result = 0;
        int currentRow = 0;

        while (true)
        {
            result++;

            if (visited[currentRow][col])
            {
                return long.MinValue;
            }

            if (field[currentRow][col] < 0)
            {
                result -= field[currentRow][col];
                return result;
            }

            int nextColumn = field[currentRow][col];
            visited[currentRow][col] = true;
            col = nextColumn;

            currentRow++;

            if (currentRow == field.GetLength(0))
            {
                currentRow = 0;
            }
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] field = new int[n][];
        ProcessInput(field);
        long maxValue = long.MinValue;

        bool[][] used = new bool[n][];

        for (int i = 0; i < n; i++)
        {
            used[i] = new bool[field[i].Length];
        }

        for (int i = 0; i < field[0].Length; i++)
        {
            long specialValue = FindSpecialValue(field, i, used);

            if (maxValue < specialValue)
            {
                maxValue = specialValue;
            }
        }

        Console.WriteLine(maxValue);
    }
}