// A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
// bank name, IBAN, BIC code and 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types
// and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        /* Declaring the necessary variables */
        string firstName = "Ahmed"; /* Strings is good for names */
        string middleName = "Avantov";
        string lastName = "Dalaverov";
        decimal moneyBallance = 9999999999.99m; /* Decimal is good for working with money */
        string bankName = "ZalojnaKushta Bank";
        string iban = "AL47 2121 1009 0000 0002 3569 8741";
        string bicCode = "OKOYFIHH";
        ulong cardNumber = 378282246310005u; /* Ulong is good for big positive numbers */
        ulong cardNumber2 = 371449635398431u;
        ulong cardNumber3 = 356600202036050u;

        /* Print on the console */
        Console.WriteLine("Hello, {0} {1} {2}! Welcome to {3}", firstName, middleName, lastName, bankName + Environment.NewLine);
        Console.WriteLine("You have 3 credit card numbers: \n {0} \n {1} \n {2}", cardNumber, cardNumber2, cardNumber3 + Environment.NewLine);
        Console.WriteLine("Your IBAN is: {0}", iban);
        Console.WriteLine("Your BIC code is: {0}", bicCode + Environment.NewLine);
        Console.WriteLine("You have ${0} in your account." + Environment.NewLine, moneyBallance);
    }
}