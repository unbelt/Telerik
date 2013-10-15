using System;
using System.Collections.Generic;
using System.Linq;

class Students
{
    static void Main()
    {
        var students = new[]
        {
            new { FirstName = "Pesho", LastName = "Georgiev", Age = 18 },
            new { FirstName = "Gosho", LastName = "Petkov", Age = 20 },
            new { FirstName = "Ivan", LastName = "Ivanov", Age = 24 },
            new { FirstName = "Petko", LastName = "Dimitrov", Age = 25 },
            new { FirstName = "Stoqn", LastName = "Zahariev", Age = 16 },
        };

        /* 3. Write a method that from a given array of students finds all students whose
              first name is before its last name alphabetically. Use LINQ query operators. */
        var linqSortByName = (
            from s in students
            where s.FirstName[0] < s.LastName[0]
            select s
            );

        // 3. With lambda
        var sortByName = students.Where(student => student.FirstName[0] < student.LastName[0]);

        // 4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
        var linqSortByAge = (
            from s in students
            where s.Age > 17 && s.Age < 25
            select s
            );

        // 4. With lambda
        var sortByAge = students.Where(student => student.Age > 17 && student.Age < 25);

        /* 5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students
              by first name and last name in descending order. */
        var sortedStudents = students.OrderByDescending(student => student.FirstName).ThenBy(student => student.LastName);

        // 5.1 Rewrite the same with LINQ.
        var linqSortedStudents = (
            from s in students
            orderby s.FirstName descending
            select s
            );

        Console.WriteLine("Sort by name:");
        foreach (var student in linqSortByName)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();

        Console.WriteLine("Sort by age:");
        foreach (var student in linqSortByAge)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();

        Console.WriteLine("Sorted by name in descending order (lambda):");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();

        Console.WriteLine("Sorted by name in descending order (LINQ):");
        foreach (var student in linqSortedStudents)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine();
    }
}