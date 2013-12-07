using System;

/* 5. Define a class BitArray64 to hold 64 bit values inside an ulong value.
      Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=. */

class BitArrayTest
{
    static void Main()
    {
        BitArray visited = new BitArray(10);

        Console.WriteLine("Count: " + visited.Count);
        Console.WriteLine("Capacity: " + visited.Capacity);

        {
            visited[1] = true;
            Console.WriteLine(visited[1]);

            visited[1] = false;
            Console.WriteLine(visited[1]);
        }

        Console.WriteLine();

        {
            visited[0] = true;
            visited[visited.Count - 1] = true;
            Console.WriteLine(visited);
        }
    }
}