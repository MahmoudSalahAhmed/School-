using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class StudentTeacher : BaseModel
    {
        public virtual Teacher Teacher { get; set; }
        public int TeacherID { get; set; }
        public virtual Student Student { get; set; }
        public int StudentID { get; set; }
    }
}
