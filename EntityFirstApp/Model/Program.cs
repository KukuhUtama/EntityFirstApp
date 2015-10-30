using EntityFirstApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hello World");
            UserRepository UserRepo = new UserRepository();

            var txt = UserRepo.GetAll();
            //using (var ctx = new DbContextEF())
            //{
            //    //ctx.Database.Initialize(false);    //The database will be created immediately after calling the Initialize() method instead of waiting until the context is used for the first time. 
            //    //new DBInitializer().InitializeDatabase(ctx);
            //    //User firstUser = new User() { UserName = "Rina", Email = "kukuh2utama@gmail.com", Password = "Mitrais", AddedDate = new DateTime(2014, 1, 18), ModifiedDate = new DateTime(2014, 1, 18), IP = "localhost" };
            //    //ctx.Users.Add(firstUser);
            //    //User user = new User
            //    //{
            //    //    UserName = "xx",
            //    //    Password = "123",
            //    //    Email = "Isnati_P@test.com",
            //    //    AddedDate = DateTime.Now,
            //    //    ModifiedDate = DateTime.Now,
            //    //    IP = "1.1.1.1",
            //    //    Profile = new Profile
            //    //    {
            //    //        FirstName = "Isnatia",
            //    //        LastName = "Pipit",
            //    //        Address = "Klaten",
            //    //        AddedDate = DateTime.Now,
            //    //        ModifiedDate = DateTime.Now,
            //    //        IP = "1.1.1.1"
            //    //    },
            //    //};

            //    //ctx.Users.Add(user); 

            //    Customer customer = new Customer
            //    {
            //        Name = "Kukuh Utama",
            //        Email = "Kukuh Utama@test.com",
            //        AddedDate = DateTime.Now,
            //        ModifiedDate = DateTime.Now,
            //        IP = "1.1.1.1",
            //        Orders = new List<Order>{  
            //                                new Order  
            //                                {  
            //                                    Quanatity =12,  
            //                                    Price =15,  
            //                                    AddedDate = DateTime.Now,  
            //                                    ModifiedDate = DateTime.Now,  
            //                                     IP = "1.1.1.1",  
            //                                },  
            //                                new Order  
            //                                {  
            //                                    Quanatity =10,  
            //                                    Price =25,  
            //                                    AddedDate = DateTime.Now,  
            //                                    ModifiedDate = DateTime.Now,  
            //                                     IP = "1.1.1.1",  
            //                                }  
            //                            }
            //    };

            //    ctx.Customers.Add(customer);
            //    ctx.SaveChanges();
            //}
        }
    }
}
