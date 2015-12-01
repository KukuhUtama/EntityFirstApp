using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFirstAppWeb.Areas.Rent.Models
{
    public class RentView
    {
        public Int64 Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Int64 VideoId { get; set; }
        public Int64 UserId { get; set; }
        public int RentingLength { get; set; }
        public int RentingCost { get; set; }
    }
}