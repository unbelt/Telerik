using System;
using System.Text;
// 2.1 Define new class Student which is derived from Human and has new field – grade.

public class Student : Human
{
    public int Grade { get; set; }

    public Student(string name, string family, int grade)
        : base(name, family)
    {
        this.Grade = grade;
    }

    public override string ToString()
    {
        var print = new StringBuilder();
        print.AppendFormat("Name: {0} {1} \r\nGrade: {2}", firstName, lastName, Grade);

        return print.ToString();
    }
}