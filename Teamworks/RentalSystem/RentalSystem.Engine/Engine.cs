using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalSystem.Data;
//using RentalSystem.Data.Migrations;
using RentalSystem.Models;
using System.Data.Entity;
using System.Data.Entity.Validation;

using System.Reflection;
using System.Data.Entity.Infrastructure;

namespace RentalSystem.Engine
{
    public class Engine
    {
        public Engine()
        { }
        public RentalSystemContext Start()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<RentalSystemContext, Configuration>());
            RentalSystemContext db = new RentalSystemContext();
            return db;
        }
        public IList<Customer> LoadCustomers(RentalSystemContext db)
        {

            IList<Customer> holder = db.Customers.ToList(); ;
            // db.Customers.RemoveRange(holder);

            //db.SaveChanges();
            return holder;

        }
        public IList<Dealer> LoadDealers(RentalSystemContext db)
        {

            IList<Dealer> holder = db.Dealers.ToList(); ;
            // db.Customers.RemoveRange(holder);

            //db.SaveChanges();
            return holder;

        }
        public List<Contract> LoadContract(RentalSystemContext db, Customer cus)
        {

            List<Contract> holder = db.Contracts.Where(x => x.Customer.CustomerId == cus.CustomerId).ToList(); ;
            // db.Customers.RemoveRange(holder);

            //db.SaveChanges();
            return holder;

        }
        public void SaveCustomers(RentalSystemContext db, IList<Customer> holder)
        {

            //IList<Customer> holder = db.Customers.ToList(); ;
            foreach (Customer gr in holder)
            {
                // Customer tr = new Customer();

                db.Customers.Add(gr);
            }
            //db.SaveChanges();
            return;

        }
    }
}
