using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Bank
{
    private readonly List<Account> accounts = new List<Account>();

    public string Name { get; private set; }

    public Bank(string name)
    {
        this.Name = name;
    }

    internal Bank AddAccount(params Account[] accounts)
    {
        foreach (Account account in accounts)
        {
            this.accounts.Add(account);
        }

        return this;
    }

    public override string ToString()
    {
        var print = new StringBuilder();

        print.AppendFormat("Bank: {0}", this.Name);

        foreach (var account in accounts)
        {
            print.AppendLine(account.ToString());
        }

        return print.ToString();
    }
}