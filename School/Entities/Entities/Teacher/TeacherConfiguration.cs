using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            ToTable("Teacher");
            Property(i => i.Name).HasMaxLength(40).IsRequired();
            Property(i => i.BirthDate).IsRequired();
            HasMany(i => i.StudentTeachers).WithRequired(i => i.Teacher);
        }
    }
}
