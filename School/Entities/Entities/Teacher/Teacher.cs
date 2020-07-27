using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Teacher :BaseModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}
