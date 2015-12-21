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
    public class VideoMap : EntityTypeConfiguration<Video>
    {
        public VideoMap()
        {
            HasKey(t => t.Id);

            //Field
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Title).IsRequired().HasMaxLength(25);
            Property(t => t.Genre).IsRequired();
            Property(t => t.Count);
            Property(t => t.RentPrice);
            Property(t => t.Status);
            Property(t => t.AddedDate).IsRequired();
            Property(t => t.ModifiedDate).IsRequired();


            //Table  
            ToTable("Videos");
        }
    }
}
