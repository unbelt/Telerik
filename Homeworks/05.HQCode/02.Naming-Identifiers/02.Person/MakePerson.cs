namespace Human
{
    using System;

    public class MakePerson
    {
        public static Person MakeNewPerson(int age)
        {
            Person person = new Person();
            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = Gender.Female;
            }

            return person;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(MakeNewPerson(22));
        }
    }
}