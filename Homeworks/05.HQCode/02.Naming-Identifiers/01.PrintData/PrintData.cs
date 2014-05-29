namespace PrintData
{
    using System;

    public class PrintData
    {
        public const int MAX_COUNT = 6;

        public static void Main()
        {
            PrintValue printer = new PrintValue();
            printer.PrintBoolValue(true);
        }
    }
}