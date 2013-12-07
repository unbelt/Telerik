using System;
// 2. Define abstract class Human with first name and last name.

public abstract class Human
{
    public string firstName { get; set; }
    public string lastName { get; set; }

    public Human(string name, string family)
    {
        this.firstName = name;
        this.lastName = family;
    }
}