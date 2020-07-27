using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class TeacherExtensions
    {
        
            public static TeacherViewModel ToViewModel(this Teacher Model)
            {
                return new TeacherViewModel()
                {
                    ID = Model.ID,
                    Name = Model.Name,
                    BirthDate = Model.BirthDate
                };
            }
            public static TeacherEditViewModel ToEditableViewModel(this Teacher Model)
            {
                return new TeacherEditViewModel()
                {
                    ID = Model.ID,
                    Name = Model.Name,
                    BirthDate = Model.BirthDate
                };
            }
            public static Teacher ToModel(this TeacherEditViewModel Model)
            {
                return new Teacher()
                {
                    ID = Model.ID,
                    Name = Model.Name,
                    BirthDate = Model.BirthDate
                };
            }
        
    }
}
