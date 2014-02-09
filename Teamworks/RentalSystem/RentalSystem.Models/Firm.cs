namespace RentalSystem.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    [Table("Firms")]
    public class Firm : Customer
    {
        public Firm()
        {
        }

        public string VATNumber { get; set; }

        public override string PrepareForFileWrite()
        {
            char tab = '\t';
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);
            sb.Append(tab);
            sb.Append(this.VATNumber);
            sb.Append(tab);
            sb.Append(this.City);
            sb.Append(tab);
            sb.Append(this.Address);
            sb.Append(tab);
            sb.Append(this.Phone);
            sb.Append(tab);
            sb.Append(this.Comment);
            sb.Append(tab);
            sb.Append(this.CustomerType);
            return sb.ToString();
        }
    }
}