﻿using System;
using System.Collections.Generic;
/* 2. A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
      Customers could be individuals or companies. All accounts have customer, balance and interest rate (monthly based).
      Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
      All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as
      follows: number_of_months * interest_rate. Loan accounts have no interest for the first 3 months if are held by individuals
      and for the first 2 months if are held by a company. Deposit accounts have no interest if their balance is positive
      and less than 1000. Mortgage accounts have ½ interest for the first 12 months for companies and no interest
      for the first 6 months for individuals. Your task is to write a program to model the bank system by classes and interfaces.
      You should identify the classes, interfaces, base classes and abstract actions and implement
      the calculation of the interest functionality through overridden methods. */

class BankTest
{
    static void Main()
    {
        Console.WriteLine(
        new Bank("OBB").AddAccount(new Deposit(300, 0.2m,
                                   new CompanyCustomer("Obama")).Withdrawing(150).MakeDeposit(35).MakeDeposit(75))

                       .AddAccount(new Mortgage(500, 0.3m,
                                   new IndividualCustomer("Pesho")).MakeDeposit(500))

                       .AddAccount(new Loan(1000, 0.1m,
                                   new CompanyCustomer("Osama")).MakeDeposit(10000))
        );

        // Interest test
        InterestCalculator(new Deposit(100, 0.3m, new CompanyCustomer("Hulk")), 6);
    }

    static void InterestCalculator(Account acc, decimal months = 6)
    {
        Console.WriteLine();
        Console.WriteLine(acc.Customer);
        Console.WriteLine("Hulk's ballance: {0}", acc.GetBallance());
        Console.WriteLine();

        for (int i = 1; i <= months; i++)
        {
            Console.WriteLine("Month {0} - {1}", i, acc.GetInterest(i));
        }
    }
}