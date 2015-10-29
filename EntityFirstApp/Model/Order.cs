using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp
{
    public class Order : BaseEntity
    {
        public byte Quanatity { get; set; }
        public Decimal Price { get; set; }
        public Int64 CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    } 
}
