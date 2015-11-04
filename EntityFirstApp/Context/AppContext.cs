﻿using EntityFirstApp.Base;
using EntityFirstApp.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Context
{
    public class AppContext : DataContext
    {
        private IDbSet<Profile> _profiles;
        private IDbSet<User> _users;
        private IDbSet<Customer> _customers;
        private IDbSet<Order> _orders;
        
        static AppContext()
        {
            Database.SetInitializer<DbContextEF>(null);
        }
        public AppContext(): base("name=EF_Context")
        {
            
            //Disable initializer
            Database.SetInitializer<DbContextEF>(null);
        }

        public DbContext DbContext
        {
            get
            {
                return this;
            }
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
                modelBuilder.Configurations.Add(new StudentMap());
                modelBuilder.Configurations.Add(new CourseMap());
                base.OnModelCreating(modelBuilder);
            }
        }
    }
}
