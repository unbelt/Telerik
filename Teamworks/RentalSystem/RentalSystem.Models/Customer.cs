namespace RentalSystem.Models
{
    using System;
    using System.Collections.Generic;

    public abstract class Customer : ICustomer, IComparable<Customer>
    {
        private ICollection<Contract> contracts;

        public Customer()
        {
            this.contracts = new HashSet<Contract>();
        }

        public int CustomerId { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public CustomerType CustomerType { get; set; }

        public string Comment { get; set; }

        public virtual ICollection<Contract> Contracts
        {
            get
            {
                return this.contracts;
            }

            set
            {
                this.contracts = value;
            }
        }

        public string Name { get; set; }

        public static CustomerType GetCustomerType(string type)
        {
            return (CustomerType)Enum.Parse(typeof(CustomerType), type);
        }

        public abstract string PrepareForFileWrite();

        public int CompareTo(ICustomer other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public int CompareTo(Customer other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}