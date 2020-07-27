using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class StudentTeacherViewModel
    {
        public int ID { get; set; }
        public int TeacherID { get; set; }
        public int StudentID { get; set; }
        public TeacherViewModel Teacher { get; set; }
    }
}
