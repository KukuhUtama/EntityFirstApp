using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp
{
    public class DBInitializer : DropCreateDatabaseAlways<EFDbContext> 
    {

        public List<User> userList = new List<User>();
        public DBInitializer()
        {
            userList.Add(new User() { UserName = "Rina Setiana", Email = "kukuh2utama@gmail.com", Password = "Mitrais", AddedDate = new DateTime(2014, 1, 18), ModifiedDate = new DateTime(2014, 1, 18), IP = "localhost" });
            userList.Add(new User() { UserName = "Kukuh Utama", Email = "kukuh2utama@gmail.com", Password = "Mitrais", AddedDate = new DateTime(2014, 1, 18), ModifiedDate = new DateTime(2014, 1, 18), IP = "localhost" });
        }
      
        protected override void Seed(EFDbContext context)
        {
            foreach (User u in userList)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
