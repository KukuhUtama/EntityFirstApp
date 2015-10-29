using EntityFirstApp.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp
{
    public class DbContextEF : DbContext 
    {
        private IDbSet<Profile> _profiles;
        private IDbSet<User> _users;
        private IDbSet<Customer> _customers;
        private IDbSet<Order> _orders;

        public DbContextEF()
            : base("name=EF_Context")
        {
            //Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>()); // Default
            //Database.SetInitializer<EFDbContext>(new DBInitializer());
           // Database.SetInitializer<EFDbContext>(new DropCreateDatabaseIfModelChanges<EFDbContext>());
           // Database.SetInitializer<EFDbContext>(new DropCreateDatabaseAlways<EFDbContext>());

            //Disable initializer
            //Database.SetInitializer<EFDbContext>(null);
        }

        public IDbSet<User> Users
        {
            get
            {
                return this._users;
            }
            set
            {
                this._users = value;
            }
        }

        public IDbSet<Profile> Profiles
        {
            get
            {
                return this._profiles;
            }
            set
            {
                this._profiles = value;
            }
        }

        public IDbSet<Customer> Customers 
        {
            get
            {
                return this._customers;
            }
            set
            {
                this._customers = value;
            }
        }

        public IDbSet<Order> Orders
        {
            get
            {
                return this._orders;
            }
            set
            {
                this._orders = value;
            }
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {  //Method override from DbContext class

            if (modelBuilder != null)
            {
                modelBuilder.Configurations.Add(new ProfileMap());
                modelBuilder.Configurations.Add(new UserMap());
                modelBuilder.Configurations.Add(new OrderMap());
                modelBuilder.Configurations.Add(new CustomerMap());
                base.OnModelCreating(modelBuilder);
            }
        }
    }
}
