using System;

/* 1. Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address,
      mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
      Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=. */

/* 2. Add implementations of the ICloneable interface. The Clone()
      method should deeply copy all object's fields into a new object of type Student. */

/* 3. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
      and by social security number (as second criteria, in increasing order). */

/* 4. Create a class Person with two fields – name and age. Age can be left unspecified
      (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
      Write a program to test this functionality. */



class StudentTest
{
    static void Main()
    {
        Student firstStudnet = new Student("Pesho", "Ivanov", "Petrov", "687-65-4329", "Vasil Levski 12", 0881111111,
            "pesho@mail.bg", "C#", Universities.ScientologyUniversity, Faculties.Engineering, Specialties.SoftwareEngineering);
        Student secondStudnet = new Student("Ivan", "Ivanov", "Georgiev", "927-75-6329", "Ivan Vazov 13", 0882222222,
            "ivo@mail.bg", "PHP", Universities.SoftwareUniversity, Faculties.Science, Specialties.ComputerScience);
        Student thirdStudnet = new Student("Georgi", "Georgiev", "Ivanov", "487-55-4627", "Hristo Botev 24", 0883333333,
            "gosho@mail.bg", "Too Lazy", Universities.TechnicalUniversity, Faculties.Agriculture, Specialties.Nanotechnology);

        Console.WriteLine(firstStudnet.Universities);
        Console.WriteLine(secondStudnet);
        Console.WriteLine(thirdStudnet);

        Console.WriteLine(thirdStudnet.CompareTo(secondStudnet));
    }
}