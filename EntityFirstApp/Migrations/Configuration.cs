namespace EntityFirstApp.Migrations
{
    using EntityFirstApp.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFirstApp.DbContextEF>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EntityFirstApp.DbContextEF context)
        {
            //  This method will be called after migrating to the latest version.

            User firstUser = new User()
            {
                UserName = "Kukuh Utama",
                Email = "kukuh2utama@gmail.com",
                Password = "Mitrais",
                AddedDate = new DateTime(2014, 1, 18),
                ModifiedDate = new DateTime(2014, 1, 18),
            };

            User secondUser = new User()
            {
                UserName = "Valkriy",
                Email = "kukuh2utama@gmail.com",
                Password = "Free",
                AddedDate = new DateTime(2014, 1, 18),
                ModifiedDate = new DateTime(2014, 1, 18),
            };

            Profile firstProfileUser = new Profile()
            {
                FirstName = "First Profile",
                LastName = "Azz",
                Address = "Klaten",
                AddedDate = new DateTime(2014, 1, 18),
                ModifiedDate = new DateTime(2014, 1, 18),
                User = firstUser
            };

            Profile secondProfileUser = new Profile() 
            {
                FirstName = "Second Profile",
                LastName = "Azz",
                Address = "Klaten",
                AddedDate = new DateTime(2014, 1, 18),
                ModifiedDate = new DateTime(2014, 1, 18),
                User = secondUser
            };

         
            Video firstVideo = new Video()
            {
               Title = "Mengejar Matahari",
               Genre ="Horror",
               RentPrice =111,
               Count =10,
               Status = true,
               AddedDate = new DateTime(2015, 1, 18),
               ModifiedDate = new DateTime(2015, 1, 18)
            };

            Video secondVideo = new Video()
            {
                Title = "Mengejar Mas Mas",
                Genre = "Commedy",
                RentPrice = 111,
                Count = 10,
                Status = true,
                AddedDate = new DateTime(2015, 1, 18),
                ModifiedDate = new DateTime(2015, 1, 18)
            };

            Video thirdVideo = new Video() 
            {
                Title = "Jagad X Code",
                Genre = "Commedy",
                RentPrice = 111,
                Count = 10,
                Status = true,
                AddedDate = new DateTime(2015, 1, 18),
                ModifiedDate = new DateTime(2015, 1, 18)
            };

            Rent firstRent = new Rent()
            {
                RentingLength = 10,
                RentingCost = 1000,
                AddedDate = new DateTime(2015, 1, 18),
                ModifiedDate = new DateTime(2015, 1, 18),
                Video = firstVideo,
                User = firstUser
            };

            Rent secondRent = new Rent()
            {
                RentingLength = 11,
                RentingCost = 1111,
                AddedDate = new DateTime(2015, 1, 18),
                ModifiedDate = new DateTime(2015, 1, 18),
                Video = secondVideo,
                User = secondUser
            };

            Rent thirdRent = new Rent()
            {
                RentingLength = 11,
                RentingCost = 1111,
                AddedDate = new DateTime(2015, 1, 18),
                ModifiedDate = new DateTime(2015, 1, 18),
            };

            context.Users.AddOrUpdate(u => u.Id, firstUser);
            context.Profiles.AddOrUpdate(u => u.Id, firstProfileUser);
          
            context.Users.AddOrUpdate(u => u.Id, secondUser);
            context.Profiles.AddOrUpdate(u => u.Id, secondProfileUser);

            context.Videos.AddOrUpdate(u => u.Id, firstVideo);
            context.Videos.AddOrUpdate(u => u.Id, secondVideo);

            context.Rents.AddOrUpdate(u => u.Id, firstRent);
            context.Rents.AddOrUpdate(u => u.Id, secondRent);
           
        }
    }
}
