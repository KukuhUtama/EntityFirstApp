using EntityFirstApp.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp
{
    public class EFDbContext : DbContext
    {
        private IDbSet<Profile> _profiles;
        private IDbSet<User> _users;

        public EFDbContext()
            : base("name=EF_Context")
        {
            Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>());
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder != null)
            {
                modelBuilder.Configurations.Add(new ProfileMap());
                modelBuilder.Configurations.Add(new UserMap());
                base.OnModelCreating(modelBuilder);
            }
        }
    }
}
