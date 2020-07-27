using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class StudentTeacherExtensions
    {
        public static StudentTeacherViewModel ToViewModel(this StudentTeacher Model)
        {
            return new StudentTeacherViewModel()
            {
                ID = Model.ID,
                StudentID = Model.StudentID,
                TeacherID = Model.TeacherID,
                Teacher = Model.Teacher.ToViewModel()
            };
        }
        public static StudentTeacher ToModel(this StudentTeacherEditViewModel Model)
        {
            return new StudentTeacher()
            {
                ID = Model.ID,
                StudentID = Model.StudentID,
                TeacherID = Model.TeacherID
            };
        }
        public static StudentTeacherEditViewModel ToEditableViewModel(this StudentTeacher Model)
        {
            return new StudentTeacherEditViewModel()
            {
                ID = Model.ID,
                StudentID = Model.StudentID,
                TeacherID = Model.TeacherID
            };
        }
    }
}
