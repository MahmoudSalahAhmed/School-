using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            ToTable("Student");
            Property(i => i.Name).HasMaxLength(40).IsRequired();
            Property(i => i.BirthDate).IsRequired();
            HasRequired(i => i.Governate).WithMany(i => i.Students).
                   HasForeignKey(i => i.GovernateID);
            HasRequired(i => i.Neighborhood).WithMany(i => i.Students).
                   HasForeignKey(i => i.NeighborhoodID);
            HasRequired(i => i.Field).WithMany(i => i.Students).
                   HasForeignKey(i => i.FieldID);
            HasMany(i => i.StudentTeachers).WithRequired(i => i.Student);
        }
    }
}
