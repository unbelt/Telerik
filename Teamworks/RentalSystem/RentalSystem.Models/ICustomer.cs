namespace RentalSystem.Models
{
    public interface ICustomer
    {
        string City { get; set; }

        string Address { get; set; }

        string Phone { get; set; }

        string Comment { get; set; }

        CustomerType CustomerType { get; set; }

        string Name { get; set; }

        int CompareTo(ICustomer other);

        string ToString();
    }
}