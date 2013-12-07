using System;
using System.Text;

public class Person
{
    public string FirstName { get; private set; }
    public string MiddleName { get; private set; }
    public string LastName { get; private set; }

    public byte? Age { get; private set; }

    public Person(string firstName, string middleName, string lastName, byte? age = null)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.Age = age;
    }

    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.AppendFormat("First Name: {0} \r\n Middle Name: {1} \r\n Last Name: {2} \r\n Age: {3}",
            this.FirstName, this.MiddleName, this.LastName, this.Age ?? -1);

        return print.ToString();
    }
}