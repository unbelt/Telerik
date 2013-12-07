using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

class Class : School, ICommentable, IComparable<Class>
{
    private readonly List<Student> students = new List<Student>();
    private readonly List<Teacher> teachers = new List<Teacher>();

    public string TextIdentifier { get; set; }

    public Class(string identifier, string comment = "[N/A]")
        : base(comment)
    {
        this.TextIdentifier = identifier;
    }

    public Class AddStudent(params Student[] students)
    {
        foreach (Student student in students)
        {
            this.students.Add(student);
        }

        return this;
    }

    public Class AddTeacher(params Teacher[] teachers)
    {
        foreach (Teacher teacher in teachers)
        {
            this.teachers.Add(teacher);
        }

        return this;
    }

    public int CompareTo(Class other)
    {
        return this.TextIdentifier.CompareTo(other.TextIdentifier);
    }

    public override string ToString()
    {
        var print = new StringBuilder();
        print.AppendFormat("Class identifier: {0} \r\nComment: {1} \r\n\r\n",
                                              TextIdentifier, Comment);

        print.AppendLine("Students \r\n--------------------------");
        foreach (var student in students)
        {
            print.AppendLine(student.ToString() + Environment.NewLine);
        }

        print.AppendLine("Teachers and disciplines \r\n===========================");
        foreach (var teacher in teachers)
        {
            print.AppendLine(teacher.ToString() + Environment.NewLine);
        }

        return print.ToString();
    }
}