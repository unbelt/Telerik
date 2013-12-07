using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public enum Sex
{
    male,
    female,
};

public class Animals
{
    protected string Sound;

    public float Age { get; set; }
    public string Name { get; set; }
    public Sex Sex { get; set; }

    public Animals(float age, string name, Sex sex)
    {
        this.Age = age;
        this.Name = name;
        this.Sex = sex;

        if (this.GetType().Name == "Tomcat")
        {
            this.Sex = Sex.male;
        }
        else if (this.GetType().Name == "Kitten")
        {
            this.Sex = Sex.female;
        }
        if (this.GetType().Name == "Dog")
        {
            this.Sound = "Woof-Woof";
        }
        else if (this.GetType().Name == "Kitten")
        {
            this.Sound = "Meooow";
        }
        else if (this.GetType().Name == "Tomcat")
        {
            this.Sound = "Meow";
        }
        else if (this.GetType().Name == "Frog")
        {
            this.Sound = "Ribbit-ribbit";
        }
    }

    public void MakeSound()
    {
        Console.WriteLine("I'm a {0}, and I make {1}!", this.GetType().Name, this.Sound);
    }

    public override string ToString()
    {
        var print = new StringBuilder();
        print.AppendFormat("{0} is {1} years old {2} {3}.", this.Name, this.Age, this.Sex, this.GetType().Name);

        return print.ToString();
    }
}