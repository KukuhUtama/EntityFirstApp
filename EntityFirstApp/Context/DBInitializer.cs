using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp
{
    public class DBInitializer : DropCreateDatabaseAlways<DbContextEF> 
    {

        public List<User> userList = new List<User>();
        public DBInitializer()
        {
            userList.Add(new User() { UserName = "Rina Setiana", Email = "kukuh2utama@gmail.com", Password = "Mitrais", AddedDate = new DateTime(2014, 1, 18), ModifiedDate = new DateTime(2014, 1, 18) });
            userList.Add(new User() { UserName = "Kukuh Utama", Email = "kukuh2utama@gmail.com", Password = "Mitrais", AddedDate = new DateTime(2014, 1, 18), ModifiedDate = new DateTime(2014, 1, 18) });
        }
      
        protected override void Seed(DbContextEF context)
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
