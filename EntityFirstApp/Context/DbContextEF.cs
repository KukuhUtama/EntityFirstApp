using EntityFirstApp.Mapping;
using EntityFirstApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp
{
    public class DbContextEF : DbContext 
    {   // Will be not used 
        private IDbSet<Profile> _profiles;
        private IDbSet<User> _users;
        private IDbSet<Video> _videos;
        private IDbSet<Rent> _rents;


        static DbContextEF()
        {
            Database.SetInitializer<DbContextEF>(null);
        }
        public DbContextEF()
            : base("name=EF_Context")
        {
            //Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>()); // Default
            //Database.SetInitializer<EFDbContext>(new DBInitializer());
           // Database.SetInitializer<EFDbContext>(new DropCreateDatabaseIfModelChanges<EFDbContext>());
           // Database.SetInitializer<EFDbContext>(new DropCreateDatabaseAlways<EFDbContext>());

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

        public IDbSet<Video> Videos
        {
            get
            {
                return this._videos;
            }
            set
            {
                this._videos = value;
            }
        }

        public IDbSet<Rent> Rents
        {
            get
            {
                return this._rents;
            }
            set
            {
                this._rents = value;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {  //Method override from DbContext class

            if (modelBuilder != null)
            {
                modelBuilder.Configurations.Add(new ProfileMap());
                modelBuilder.Configurations.Add(new UserMap());
                modelBuilder.Configurations.Add(new VideoMap());
                modelBuilder.Configurations.Add(new RentMap());
                base.OnModelCreating(modelBuilder);
            }
        }
    }
}
