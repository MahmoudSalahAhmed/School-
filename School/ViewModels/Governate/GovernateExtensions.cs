using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class GovernateExtentions
    {
        public static GovernateViewModel ToViewModel(this Governate Model)
        {
            return new GovernateViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
                
            };
        }
        public static GovernateEditViewModel ToEditableViewModel(this Governate Model)
        {
            return new GovernateEditViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
           
            };
        }
        public static Governate ToModel(this GovernateEditViewModel EditModel)
        {
            return new Governate()
            {
                ID = EditModel.ID,
                Name = EditModel.Name,
                
            };
        }
    }
}
