using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class NeighborhoodExtensions
    {
        public static NeighborhoodViewModel ToViewModel(this Neighborhood Model)
        {
            return new NeighborhoodViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
                GovernateID = Model.GovernateID,
                Governate = Model.Governate.ToViewModel()
            };
        }
        public static Neighborhood ToModel(this NeighborhoodEditViewModel EditModel)
        {
            return new Neighborhood()
            {
                ID = EditModel.ID,
                Name = EditModel.Name,
                GovernateID = EditModel.GovernateID
            };
        }
        public static NeighborhoodEditViewModel ToEditableViewModel(this Neighborhood Model)
        {
            return new NeighborhoodEditViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
                GovernateID = Model.GovernateID
            };
        }
    }
}
