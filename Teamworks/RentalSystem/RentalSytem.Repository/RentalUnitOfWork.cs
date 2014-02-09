namespace RentalSystem.Repository
{
    using System;
    using System.Data.Entity;

    using RentalSystem.Data;
    using RentalSystem.Data.Migrations;
    using RentalSystem.Models;

    public class RentalUnitOfWork : IDisposable
    {
        private RentalSystemContext context = new RentalSystemContext();
        private RentalRepository<Customer> customerRepository;
        private RentalRepository<Dealer> dealerRepository;
        private RentalRepository<Machine> machineRepository;
        private RentalRepository<Accessory> accessoryRepository;
        private RentalRepository<Contract> contractRepository;

        private bool disposed = false;

        public RentalRepository<Customer> CustomerRepository
        {
            get
            {
                if (this.customerRepository == null)
                {
                    this.customerRepository = new RentalRepository<Customer>(this.context);
                }

                return this.customerRepository;
            }
        }

        public RentalRepository<Dealer> DealerRepository
        {
            get
            {
                if (this.dealerRepository == null)
                {
                    this.dealerRepository = new RentalRepository<Dealer>(this.context);
                }

                return this.dealerRepository;
            }
        }

        public RentalRepository<Machine> MachineRepository
        {
            get
            {
                if (this.machineRepository == null)
                {
                    this.machineRepository = new RentalRepository<Machine>(this.context);
                }

                return this.machineRepository;
            }
        }

        public RentalRepository<Accessory> AccessoryRepository
        {
            get
            {
                if (this.accessoryRepository == null)
                {
                    this.accessoryRepository = new RentalRepository<Accessory>(this.context);
                }

                return this.accessoryRepository;
            }
        }

        public RentalRepository<Contract> ContractRepository
        {
            get
            {
                if (this.contractRepository == null)
                {
                    this.contractRepository = new RentalRepository<Contract>(this.context);
                }

                return this.contractRepository;
            }
        }

        public void Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RentalSystemContext, Configuration>());

            // RentalSystemContext db = new RentalSystemContext();
            // return db;
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }

            this.disposed = true;
        }
    }
}
