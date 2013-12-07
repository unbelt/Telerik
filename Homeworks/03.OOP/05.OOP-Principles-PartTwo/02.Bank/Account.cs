using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public abstract class Account
{
    public decimal Ballance { get; set; }
    public decimal InterestRate { get; private set; }
    public Customer Customer { get; private set; }

    public Account(decimal ballance, decimal interest, Customer customer)
    {
        this.InterestRate = interest;
        this.Ballance = ballance;
        this.Customer = customer;
    }

    public Account MakeDeposit(decimal value)
    {
        this.Ballance += value;

        return this;
    }

    public virtual decimal GetInterest(decimal months)
    {
        if (months < 0)
        {
            return 0;
        }

        return this.Ballance * this.InterestRate * months;
    }

    public decimal GetBallance()
    {
        return this.Ballance;
    }

    public override string ToString()
    {
        var print = new StringBuilder();
        print.AppendLine();
        print.AppendLine();

        print.AppendFormat(@"Customer:     {0}
                             Account type: {1}
                             Ballance:     {2}
                             Inerest rate: {3}", this.Customer.Name, GetType().Name, this.Ballance, this.InterestRate);

        return print.ToString();
    }
}