using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFirstApp.Mapping
{
    public class ProfileMap : EntityTypeConfiguration<Profile>
    {
        public ProfileMap()
        {
            //key  
            this.HasKey(t => t.Id);

            //fields  
            this.Property(t => t.FirstName);
            this.Property(t => t.LastName);
            this.Property(t => t.Address).HasMaxLength(100).HasColumnType("nvarchar");
            this.Property(t => t.AddedDate);
            this.Property(t => t.ModifiedDate);
         
            //table  
            ToTable("UserProfiles");

            //Relationship
            //this.HasRequired(t => t.User).WithRequiredDependent(u => u.Profile);

        }
    }
}

