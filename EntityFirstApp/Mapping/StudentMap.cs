using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            //key  
            HasKey(t => t.Id);

            //property  
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name);
            Property(t => t.Age);
            Property(t => t.IsCurrent);
            Property(t => t.AddedDate).IsRequired();
            Property(t => t.ModifiedDate).IsRequired();


            //table  
            ToTable("Students");

            //Relationship
            HasMany(s => s.Courses).WithMany(t => t.Students).Map(t => t.ToTable("StudentCourse").MapRightKey("StudentId").MapLeftKey("CourseId"));
        }
    }
}
