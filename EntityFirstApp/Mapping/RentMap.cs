using EntityFirstApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Mapping
{
    public class RentMap : EntityTypeConfiguration<Rent>
    {
        public RentMap()
        {
            this.HasKey(t => t.Id);

            //Field
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.RentingLength).IsRequired();
            Property(t => t.RentingCost).IsRequired();
            Property(t => t.AddedDate).IsRequired();
            Property(t => t.ModifiedDate).IsRequired();


            Property(t => t.VideoId);
            Property(t => t.UserId);

            //Table  
            ToTable("Rents");

            //Relationship
            this.HasRequired(t => t.Video).WithMany(t => t.Rents).HasForeignKey(t => t.VideoId).WillCascadeOnDelete(true);
            this.HasRequired(t => t.User).WithMany(t => t.Rents).HasForeignKey(t => t.UserId).WillCascadeOnDelete(false);
        }
    }
}
