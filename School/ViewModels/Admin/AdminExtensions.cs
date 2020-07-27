using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ViewModels
{
    public static class AdminExtensions
    {
        public static AdminEditViewModel ToEditableViewModel(this Admin model)
        {
            return new AdminEditViewModel
            {
                ID = model.ID,
                Name = model.Name,
                UserName = model.UserName,
                Password = model.Password
            };
        }
        public static Admin ToModel(this AdminEditViewModel model)
        {
            return new Admin()
            {
                ID = model.ID,
                Name = model.Name,
                UserName = model.UserName,
                Password = model.Password
            };
        }
        public static AdminViewModel ToViewModel(this Admin model)
        {
            return new AdminViewModel()
            {
                ID = model.ID,
                Name = model.Name,
                UserName = model.UserName,
                Password = model.Password
            };
        }
    }
}
