namespace RentalSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    [Table("People")]
    public class Person : Customer
    {
        public Person()
        {
        }

        public string EGN { get; set; }

        public string PersonalCardNumber { get; set; }

        public DateTime PCNDate { get; set; }

        public string DrivingLicense { get; set; }

        public DateTime DLDate { get; set; }

        public override string PrepareForFileWrite()
        {
            var tab = Environment.NewLine;
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);
            sb.Append(tab);

            sb.Append(this.EGN);
            sb.Append(tab);
            sb.Append(this.City);
            sb.Append(tab);
            sb.Append(this.Address);
            sb.Append(tab);
            sb.Append(this.Phone);
            sb.Append(tab);
            sb.Append(this.PersonalCardNumber);
            sb.Append(tab);
            sb.Append(this.PCNDate);
            sb.Append(tab);
            sb.Append(this.DrivingLicense);
            sb.Append(tab);
            sb.Append(this.DLDate);
            sb.Append(tab);
            sb.Append(this.Comment);
            sb.Append(tab);
            sb.Append(this.CustomerType);
            return sb.ToString();
        }
    }
}