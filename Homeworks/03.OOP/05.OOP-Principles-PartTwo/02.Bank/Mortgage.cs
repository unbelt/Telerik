using System;

public class Mortgage : Account
{
    public Mortgage(decimal ballance, decimal interest, Customer customer) : base(ballance, interest, customer) { }

    public override decimal GetInterest(decimal months)
    {
        if (this.Customer is IndividualCustomer)
        {
            return base.GetInterest(months - 6);
        }
        if (this.Customer is CompanyCustomer)
        {
            if (months <= 12)
            {
                return base.GetInterest(months) / 2;
            }
            if (months > 12)
            {
                return base.GetInterest(months);
            }
            return base.GetInterest(months);
        }

        return base.GetInterest(months);
    }
}