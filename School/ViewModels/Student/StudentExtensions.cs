using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class StudentExtensions
    {
        public static StudentViewModel ToViewModel(this Student Model)
        {
            return new StudentViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
                BirthDate = Model.BirthDate,
                FieldID = Model.FieldID,
                GovernateID = Model.GovernateID,
                NeighborhoodID = Model.NeighborhoodID,
                Governate = Model.Governate.ToViewModel(),
                Neighborhood = Model.Neighborhood.ToViewModel(),
                Field = Model.Field.ToViewModel(),
                StudentTeachers = Model.StudentTeachers.Select(i=>i.ToViewModel()).ToList()
            };
        }
        public static StudentEditViewModel ToEditableViewModel(this Student Model)
        {
            return new StudentEditViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
                BirthDate = Model.BirthDate,
                FieldID = Model.FieldID,
                GovernateID = Model.GovernateID,
                NeighborhoodID = Model.NeighborhoodID
            };
        }
        public static Student ToModel(this StudentEditViewModel Model)
        {
            return new Student()
            {
                ID = Model.ID,
                Name = Model.Name,
                BirthDate = Model.BirthDate,
                FieldID = Model.FieldID,
                GovernateID = Model.GovernateID,
                NeighborhoodID = Model.NeighborhoodID
            };
        }

    }
}
