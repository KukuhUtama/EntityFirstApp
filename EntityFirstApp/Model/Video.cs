using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Model
{
    public class Video : BaseEntity
    {
        public string Tittle { get; set; }
        public string Genre { get; set; }
        public int RentPrice { get; set; }
        public int Count { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Rent> Rent { get; set; }
    }
}
