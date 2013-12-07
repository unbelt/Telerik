using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

class Teacher : Human, ICommentable
{
    private readonly SortedSet<Discipline> disciplines = new SortedSet<Discipline>();

    public Teacher(string name, string family, string comment = "[N/A]")
        : base(name, family, comment)
    {
    }

    public Teacher AddDiscipline(params Discipline[] disciplines)
    {
        foreach (Discipline discipline in disciplines)
        {
            this.disciplines.Add(discipline);
        }

        return this;
    }

    public override string ToString()
    {
        var print = new StringBuilder();
        print.AppendFormat("Teacher name: {0} {1} \r\nComment: {2} \r\n\r\n",
                                               FirstName, LastName, Comment);

        print.AppendLine("Discpilnes \r\n-------------");
        foreach (var discipline in disciplines)
        {
            print.AppendLine(discipline.ToString() + Environment.NewLine);
        }

        return print.ToString();
    }
}