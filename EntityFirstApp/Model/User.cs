using EntityFirstApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp
{
  
     public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Profile Profile { get; set; }
        public virtual ICollection<Rent> Rent { get; set; }
       
    }
}
