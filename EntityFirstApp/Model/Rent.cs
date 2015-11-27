using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Model
{
    public class Rent : BaseEntity
    {
        public Int64 VideoId { get; set; }
        public Int64 UserId { get; set; }
        public virtual Video Video{get;  set;}
        public virtual User User{get; set;}
        public int RentingLength { get; set; }
        public int RentingCost { get; set; }
    }
}
