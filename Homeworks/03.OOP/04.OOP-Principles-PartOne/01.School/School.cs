using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

class School : ICommentable, IEnumerable
{
    private readonly SortedSet<Class> classes = new SortedSet<Class>();

    public string Name { get; set; }
    public string Comment { get; set; }

    public School(string name, string comment = "[N/A]")
    {
        this.Name = name;
        this.Comment = comment;
    }

    public School AddClass(params Class[] classes)
    {
        foreach (Class _class in classes)
        {
            this.classes.Add(_class);
        }

        return this;
    }

    public IEnumerator GetEnumerator()
    {
        return this.classes.GetEnumerator();
    }

    public override string ToString()
    {
        var print = new StringBuilder();
        print.AppendFormat("School name: {0} \r\n########################## \r\nComment: {1} \r\n\r\n", Name, Comment);

        foreach (var _class in classes)
        {
            print.AppendLine("Classes and students \r\n======================");
            print.AppendLine(_class.ToString() + Environment.NewLine);
        }

        return print.ToString();
    }
}