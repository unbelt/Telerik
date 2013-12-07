using System;
using System.Text;

class Student : Human, ICommentable
{
    public int ID { get; set; }

    public Student(int id, string name, string family, string comment = "[N/A]")
        : base(name, family, comment)
    {
        this.ID = id;
    }

    public override string ToString()
    {
        var print = new StringBuilder();
        print.AppendFormat("Student name: {0} {1} \r\nID: {2} \r\nComment: {3}",
                                              FirstName, LastName, ID, Comment);
        return print.ToString();
    }
}