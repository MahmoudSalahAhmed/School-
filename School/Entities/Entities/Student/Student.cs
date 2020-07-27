using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Student : BaseModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int GovernateID { get; set; }
        public int NeighborhoodID { get; set; }
        public int FieldID { get; set; }
        public virtual Governate Governate { get; set; }
        public virtual Neighborhood Neighborhood { get; set; }
        public virtual Field Field { get; set; }
        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}
