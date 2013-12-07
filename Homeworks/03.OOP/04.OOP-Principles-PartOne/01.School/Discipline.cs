using System;
using System.Text;

class Discipline : School, ICommentable, IComparable<Discipline>
{
    public int NumberOfLectures { get; set; }
    public int NumberOfExercises { get; set; }

    public Discipline(int lectures, int exercises, string name, string comment = "[N/A]")
        : base(name, comment)
    {
        this.Name = name;
        this.Comment = comment;
        this.NumberOfLectures = lectures;
        this.NumberOfExercises = exercises;
    }

    public int CompareTo(Discipline other)
    {
        return this.Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        var print = new StringBuilder();
        print.AppendFormat("Name: {0} \r\nLectures: {1} \r\nExercises: {2} \r\nComment: {3}",
                                         Name, NumberOfLectures, NumberOfExercises, Comment);
        return print.ToString();
    }
}