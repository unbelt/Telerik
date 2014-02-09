namespace RentalSystem.Models
{
    using System;

    public class Accessory : ITool // , IComparable<Accessory>
    {
        private int count;
        private string name;

        public int AccessoryID { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Tool name cannot be null");
                }

                this.name = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number of accesories");
                }

                this.count = value;
            }
        }

        public int CompareTo(Accessory other)
        {
            return this.name.CompareTo(other.name);
        }

        public int CompareTo(ITool other)
        {
            return this.name.CompareTo((other as Accessory).name);
        }
    }
}