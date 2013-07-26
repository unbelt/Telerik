using System;

namespace SequenceOfNumbers
{
    class Sequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 12; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}