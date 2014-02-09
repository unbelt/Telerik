namespace RentalSystem.Models
{
    using System;

    public class Machine : ITool
    {
        private string name;

        public Machine()
        {
        }

        public int MachineId { get; set; }

        public int MachineNumber { get; set; }

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

        public int? ContractId { get; set; }

        // public virtual Contract Contract { get; set; }
        public void returnTool()
        {
            this.ContractId = null;
        }

        public int CompareTo(Machine other)
        {
            return (this.name + this.MachineNumber.ToString()).CompareTo(other.name + other.MachineNumber.ToString());
            throw new NotImplementedException();
        }

        public int CompareTo(ITool other)
        {
            return (this.name + this.MachineNumber.ToString()).CompareTo((other as Machine).name + (other as Machine).MachineNumber.ToString());
            throw new NotImplementedException();
        }
    }
}