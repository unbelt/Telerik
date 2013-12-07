using System;
using System.Collections.Generic;
/* 1. We are given a school. In the school there are classes of students. Each class has a set of teachers.
      Each teacher teaches a set of disciplines. Students have name and unique class number.
      Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises.
      Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments
      (free text block).
	  Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
      encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio. */

public class SchoolTest
{
    static void Main()
    {
        Console.WriteLine(
            new School("Vasil Levski")
            .AddClass(new Class("12b").AddStudent(new Student(12, "Pesho", "Petrov"))
            .AddStudent(new Student(9, "Penka", "Ivanova"))

            .AddTeacher(new Teacher("Mariana", "Dobreva", "The best teacher!")
            .AddDiscipline(new Discipline(2, 4, "Deuch"))
            .AddDiscipline(new Discipline(4, 6, "English", "I love this!")))

            .AddTeacher(new Teacher("Ivan", "Dobrevski", "Smart guy")
            .AddDiscipline(new Discipline(3, 5, "Math", "I hate that!"))))
            );
    }
}