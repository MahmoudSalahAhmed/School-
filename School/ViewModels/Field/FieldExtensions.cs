using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class FieldExtentions
    {
        public static FieldViewModel ToViewModel(this Field Model)
        {
            return new FieldViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
            };
        }
        public static FieldEditViewModel ToEditableViewModel(this Field Model)
        {
            return new FieldEditViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
            };
        }
        public static Field ToModel(this FieldEditViewModel EditModel)
        {
            return new Field()
            {
                ID = EditModel.ID,
                Name = EditModel.Name,
            };
        }
    }
}
