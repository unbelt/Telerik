using System.Text;
public class Deposit : Account, IDisposable
{
    public Deposit(decimal ballance, decimal interest, Customer customer) : base(ballance, interest, customer) { }

    public override decimal GetInterest(decimal months)
    {
        if (this.Ballance < 0 && this.Ballance < 1000)
        {
            return 0;
        }

        return base.GetInterest(months);
    }

    public Account Withdrawing(decimal value)
    {
        this.Ballance -= value;

        return this;
    }
}