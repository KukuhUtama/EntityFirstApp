using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            //Key  
            HasKey(t => t.Id);

            //Field
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.UserName).IsRequired().HasMaxLength(25);
            Property(t => t.Email).IsRequired();
            Property(t => t.AddedDate).IsRequired();
            Property(t => t.ModifiedDate).IsRequired();
      
            //Table  
            ToTable("Users");

            //Relathionship
            this.HasOptional(t => t.Profile).WithRequired(u => u.User).WillCascadeOnDelete(true);
  
        }
    }
}