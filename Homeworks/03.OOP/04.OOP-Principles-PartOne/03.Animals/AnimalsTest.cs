using System;
using System.Collections.Generic;
using System.Linq;
/* 3. Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
      Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
      Kittens and tomcats are cats. All animals are described by age, name and sex.
      Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
      Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method
      (you may use LINQ). */

class AnimalsTest
{
    static void Main()
    {
        List<Animals> animals = new List<Animals>()
        {
            new Dog(6, "Balkan", Sex.male),
            new Dog(9, "Vihur", Sex.male),
            new Dog(12, "Didi", Sex.female),
            new Frog(0.5f, "Glummy", Sex.male),
            new Frog(0.1f, "Bloody", Sex.female),
            new Kitten(0.6f, "Kiki", Sex.female),
            new Kitten(0.8f, "Mimi", Sex.female),
            new Kitten(0.7f, "Sisi", Sex.female),
            new Kitten(1, "Lily", Sex.female),
            new Tomcat(4, "Tommy", Sex.male),
            new Tomcat(8, "Tony", Sex.male),
        };

        animals.Printer(); // Print all animals

        Console.WriteLine("\r\n--------------------------------------\r\n");

        // Select only one animal of each type
        var eachType = animals.GroupBy(a => a.GetType().Name)
            .Select(g => g.OrderByDescending(a => a.GetType().Name)
                .FirstOrDefault());

        foreach (var animal in eachType)
        {
            animal.MakeSound(); // Print sound
        }

        // Calculate average ages of each type of animals
        Console.WriteLine("\r\n--------------------------------------\r\n");
        CalculateAverageAge.CalculateAge(animals, "Dog");
        CalculateAverageAge.CalculateAge(animals, "Kitten");
        CalculateAverageAge.CalculateAge(animals, "Tomcat");
        CalculateAverageAge.CalculateAge(animals, "Frog");
    }
}