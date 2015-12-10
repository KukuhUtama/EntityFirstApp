using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFirstAppWeb.Areas.User.Models
{
    public class UserView
    {
        public Int64 Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        
    }
}