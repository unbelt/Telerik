namespace PrintData
{
    using System;

    public class PrintValue
    {
        public void PrintBoolValue(bool value)
        {
            string valueToPrint = value.ToString();
            Console.WriteLine(valueToPrint);
        }
    }
}
