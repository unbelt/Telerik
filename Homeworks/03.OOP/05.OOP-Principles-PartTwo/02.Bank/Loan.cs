using System;

public class Loan : Account
{
    public Loan(decimal ballance, decimal interest, Customer customer) : base(ballance, interest, customer) { }

    public override decimal GetInterest(decimal months)
    {
        if (this.Customer is IndividualCustomer)
        {
            return base.GetInterest(months - 3);
        }
        if (this.Customer is CompanyCustomer)
        {
            return base.GetInterest(months - 2);
        }

        return base.GetInterest(months);
    }
}