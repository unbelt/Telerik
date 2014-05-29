namespace Human
{
    class Person
    {
        public void MakePerson(int age)
        {
            Human person = new Human();
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
        }
    }
}

