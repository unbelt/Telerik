namespace RentalSystem.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using RentalSystem.Data;
    using RentalSystem.Data.Migrations;
    using System.Windows;
    using System.Windows.Forms;
    


    public class RentalRepository<TEntity> where TEntity : class
    {
        internal RentalSystemContext context;
        internal DbSet<TEntity> dbSet;

        public RentalRepository(RentalSystemContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public void Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RentalSystemContext, Configuration>());

            // RentalSystemContext db = new RentalSystemContext();
            // return db;
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = this.dbSet;
            IEnumerable<TEntity> result = new List<TEntity>();
            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                result = orderBy(query).ToList();

            }
            else
            {
                result = query.ToList();

            }
            TypeInfo t = typeof(TEntity).GetTypeInfo();
            string type2 = t.ToString().Substring(t.ToString().LastIndexOf('.') + 1);
           
            
            try
            {
                if (result.Count() == 0) { throw new NoEntriesFoundException("No entries found in "+type2+" table"); }
            }

            catch (NoEntriesFoundException e)
            { MessageBox.Show(e.Message, "An exception occurred", MessageBoxButtons.OK); }

            return result;
            

        }

        public virtual TEntity GetByID(object id)
        {
            return this.dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            this.dbSet.Add(entity);
        }


        public virtual void Delete(object id)
        {
            TEntity entityToDelete = this.dbSet.Find(id);
            this.Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                this.dbSet.Attach(entityToDelete);
            }

            this.dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            this.dbSet.Attach(entityToUpdate);
            this.context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}