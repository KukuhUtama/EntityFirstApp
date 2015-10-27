namespace EntityFirstApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFirstApp.EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EntityFirstApp.EFDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            User firstUser = new User(){ UserName = "Kukuh Utama", Email = "kukuh2utama@gmail.com", Password = "Mitrais", AddedDate = new DateTime(2014, 1, 18), ModifiedDate = new DateTime(2014, 1, 18), IP = "localhost" };
            Profile profileUser = new Profile(){FirstName="Ren", LastName="Azz", Address="Klaten", AddedDate = new DateTime(2014, 1, 18), ModifiedDate = new DateTime(2014, 1, 18), IP = "localhost" };
            context.Users.AddOrUpdate(u => u.ID, firstUser);
            context.Profiles.AddOrUpdate(p => p.ID, profileUser);
        }
    }
}
