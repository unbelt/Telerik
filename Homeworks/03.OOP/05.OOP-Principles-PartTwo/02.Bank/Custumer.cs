using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public abstract class Customer : Bank
{
    public Customer(string name) : base(name) { }

    public override string ToString()
    {
        var print = new StringBuilder();
        print.AppendFormat("Customer name: {0}", this.Name);

        return print.ToString();
    }
}