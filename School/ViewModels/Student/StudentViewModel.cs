using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int GovernateID { get; set; }
        public int NeighborhoodID { get; set; }
        public int FieldID { get; set; }
        public GovernateViewModel Governate { get; set; }
        public NeighborhoodViewModel Neighborhood { get; set; }
        public FieldViewModel Field { get; set; }
        public ICollection<StudentTeacherViewModel> StudentTeachers { get; set; }

    }
}
