using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Mapping
{
     public class CustomerMap : EntityTypeConfiguration<Customer>
    {
         public CustomerMap()
         {
             //key  
             HasKey(t => t.Id);

             //properties  
             Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
             Property(t => t.Name);
             Property(t => t.Email);
             Property(t => t.AddedDate);
             Property(t => t.ModifiedDate);
             
             //table  
             ToTable("Customers");
         }
    }
}
