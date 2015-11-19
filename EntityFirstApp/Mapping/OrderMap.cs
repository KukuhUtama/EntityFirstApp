using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Mapping
{
    public class OrderMap: EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            //key  
            HasKey(t => t.Id);

            //Fields  
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Quanatity);
            Property(t => t.Price);
            Property(t => t.CustomerId);
            Property(t => t.AddedDate);
            Property(t => t.ModifiedDate);
           

            //Table  
            ToTable("Orders"); 

            //Relationship
            HasRequired(c => c.Customer).WithMany(o => o.Orders).HasForeignKey(f => f.CustomerId).WillCascadeOnDelete(true);
        }
    }
}
