using System;
using System.Collections.Generic;
using System.Linq;

public class PeoplesTest
{
    static void Main()
    {
        // 2.3 Initialize a list of 10 students and sort them by grade in ascending order
        //      (use LINQ or OrderBy() extension method).
        Console.WriteLine("Students \r\n---------------");
        List<Student> students = new List<Student>()
        {
                new Student("Pesho", "Petrov", 12),
                new Student("Gosho", "Georgiev", 8),
                new Student("Sasho", "Ivanov", 9),
        };

        // Print sorted students
        students.OrderBy(student => student.Grade).Printer();

        // 2.4 Initialize a list of 10 workers and sort them by money per hour in descending order.
        Console.WriteLine("\r\nWorkers \r\n------------");
        List<Worker> workers = new List<Worker>()
        {
                new Worker("Dancho", "Dimotorv", 650, 8),
                new Worker("Petko", "Iliev", 1650, 12),
                new Worker("Barak", "Obama", 123700, 2),
        };

        // Print sorted workers
        workers.OrderBy(worker => worker.MoneyPerHour()).Printer();

        // 2.5 Merge the lists and sort them by first name and last name.
        List<Human> peoples = new List<Human>();
        peoples.AddRange(students);
        peoples.AddRange(workers);

        Console.WriteLine("\r\nSort all by names?\r\n");
        Console.ReadKey();

        // Print all sorted by name
        peoples.OrderBy(people => people.firstName).ThenBy(people => people.lastName).Printer();
    }
}