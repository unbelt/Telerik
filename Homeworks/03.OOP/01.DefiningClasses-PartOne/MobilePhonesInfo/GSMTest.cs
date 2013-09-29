// 7. Write a class GSMTest to test the GSM class

using System;
using System.Threading;

class GSMTest
{
    static void Main()
    {
        Console.WriteLine(" -----------------");
        Console.WriteLine("|1. All GSM info  |");
        Console.WriteLine("|2. IPhone 4S info|");
        Console.WriteLine("|3. Calls info    |");
        Console.WriteLine("|0. Exit          |");
        Console.WriteLine(" -----------------");

        Console.Write("Choose an option: ");
        byte input = byte.Parse(Console.ReadLine());

        Console.WriteLine();

        switch (input)
        {
            case 1: GSMInfo(); break;
            case 2: StaticGSMInfo(); break;
            case 3: CallsInfo(); break;
            case 0: Environment.Exit(1); break;
            default: Console.WriteLine("Oops! Try again?");
                Main(); break;
        }
    }

    private static void GSMInfo()
    {
        // 7.1 Create an array of few instances of the GSM class.
        GSM[] phone = new GSM[2];

        GSM firstGSM = new GSM("N95", "Nokia", 350.00f, "Pesho");
        phone[0] = firstGSM;

        GSM secondGSM = new GSM("Galaxy", "Samsung", 850.90f, "Vasko");
        phone[1] = secondGSM;

        // 7.2 Display the information about the GSMs in the array.
        for (int i = 0; i < phone.Length; i++)
        {
            Console.WriteLine(i + 1 + " Phone");
            Console.WriteLine("-------------");
            Console.WriteLine(phone[i] + Environment.NewLine);
        }

        Main();
    }
    
    private static void StaticGSMInfo()
    {
        // 7.3 Display the information about the static property IPhone4S.
        Console.WriteLine("Static Phone");
        Console.WriteLine("-------------");
        Console.WriteLine(GSM.IPhone + Environment.NewLine);

        Main();
    }

    private static void CallsInfo()
    {
        // 12. Test the call history functionality of the GSM class.
        GSM gsm = new GSM("Optimus", "LG"); // 12.1 Create an instance of the GSM class.

        // 12.2 Add few calls.
        gsm.AddCall(DateTime.Now, 0871111111, 60);
        gsm.AddCall(DateTime.Now, 0882222222, 200);
        gsm.AddCall(DateTime.Now, 0893333333, 1234);

        // 12.3 Display the information about the calls.
        gsm.PrintHistory();

        /* 12.4 Assuming that the price per minute is 0.37
                Calculate and print the total price of the calls in the history. */
        Console.WriteLine("The cost of calls is: {0:C2}", gsm.CallPrice(0.37f));

        // 12.5 Remove the longest call from the history and calculate the total price again.
        gsm.DeleteCall(1234);
        Console.WriteLine("The cost of calls without the longest one is: {0:C2}", gsm.CallPrice(0.37f));

        // 12.6 Finally clear the call history and print it.
        gsm.ClearHistory();
        gsm.PrintHistory();
        Console.WriteLine("History is cleared!" + Environment.NewLine);

        Main();
    }
}