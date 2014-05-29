namespace Human
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Person
    {
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} Age: {1} Sex: {2}", this.Name, this.Age, this.Gender);
        }
    }
}
