using System;

class Human : IComparable<Human>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Comment { get; set; }

    public Human(string name, string family, string comment = "[N/A]")
    {
        this.FirstName = name;
        this.LastName = family;
        this.Comment = comment;
    }

    public int CompareTo(Human other)
    {
        return this.LastName.CompareTo(other.LastName);
    }
}