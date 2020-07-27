using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class StudentTeacherConfiguration : EntityTypeConfiguration<StudentTeacher>
    {
        public StudentTeacherConfiguration()
        {
            ToTable("StudentTeacher");

            HasRequired(i => i.Teacher).WithMany(i => i.StudentTeachers).
                HasForeignKey(i => i.TeacherID);

            HasRequired(i => i.Student).WithMany(i => i.StudentTeachers).
                HasForeignKey(i => i.StudentID);
        }
    }
}
