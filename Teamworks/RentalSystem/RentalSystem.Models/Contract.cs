namespace RentalSystem.Models
{
    using System;
    using System.Collections.Generic;

    public class Contract : IArchivable, IComparable<Contract>
    {
        private static List<Promotion> promotions=new List<Promotion>()
	{
	    new Promotion{startDate=new DateTime(2013,12,7),
            discount=50,
            endDate=new DateTime(2013,12,29)
        },
         new Promotion{startDate=new DateTime(2012,12,7),
            discount=50,
            endDate=new DateTime(2012,12,29)
        }
	   
	};

        private ICollection<Machine> machines;
        private ICollection<Accessory> accessories;
       
        public Contract()
        {
            this.machines = new HashSet<Machine>();
            this.accessories = new HashSet<Accessory>();
        }

        public int ContractId { get; set; }

        public int ContractNo { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual ICollection<Machine> Machines
        {
            get
            {
                return this.machines;
            }

            set
            {
                this.machines = value;
            }
        }

        public virtual ICollection<Accessory> Accessories
        {
            get
            {
                return this.accessories;
            }

            set
            {
                this.accessories = value;
            }
        }

        public DateTime ReturnDate { get; set; }

        public int DealerId { get; set; }

        public virtual Dealer Dealer { get; set; }

        // public string Comment { get; set; }
        public decimal TotalPrice { get; set; }

        public decimal Advance { get; set; }

        public bool IsArchived { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public void AddTool(Machine tool)
        {
            this.Machines.Add(tool);
        }

        public void Archive()
        {
            this.IsArchived = true;
        }

        public int CompareTo(Contract other)
        {
            return this.ContractNo.CompareTo(other.ContractNo);
        }
        public void GetPromoted()
        {
            foreach(Promotion promo in promotions )
            if(this.CreationDate>=promo.startDate&&this.CreationDate<=promo.endDate)
            {
                this.TotalPrice = (100m - promo.discount) / 100 * this.TotalPrice; return;
            }
        }
    }
}
