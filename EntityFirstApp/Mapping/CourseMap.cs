using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp
{
    public class CourseMap : EntityTypeConfiguration<Course>
    {
        public CourseMap()
        {
            //property  
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name);
            Property(t => t.MaximumStrength);
            Property(t => t.AddedDate).IsRequired();
            Property(t => t.ModifiedDate).IsRequired();
            

            //table  
            ToTable("Courses");  
        }
    }
}
