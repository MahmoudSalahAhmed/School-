using Entities.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Services
{
    public class FieldService
    {
        UnitOfWork unitOfWork;
        Generic<Field> FieldRepo;
        public FieldService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            FieldRepo = unitOfWork.FieldRepo;
        }
        public FieldEditViewModel Add(FieldEditViewModel FieldEditViewModel)
        {
            Field Field = FieldRepo.Add(FieldEditViewModel.ToModel());
            unitOfWork.commit();
            return Field.ToEditableViewModel();
        }
        public FieldEditViewModel Update(FieldEditViewModel FieldEditViewModel)
        {
            Field Field = FieldRepo.Update(FieldEditViewModel.ToModel());
            unitOfWork.commit();
            return Field.ToEditableViewModel();
        }
        public void Remove(int id)
        {
            FieldRepo.Remove(FieldRepo.GetByID(id));
            unitOfWork.commit();
        }
        public IEnumerable<FieldViewModel> Get(int id)
        {
            return FieldRepo.Get(i => i.ID == id).ToList().Select(i => i.ToViewModel());
        }
        public IEnumerable<FieldViewModel> GetAll()
        {
            return FieldRepo.GetAll().ToList().Select(i => i.ToViewModel());
        }
        public FieldViewModel GetByID(int id)
        {
            return FieldRepo.GetByID(id).ToViewModel();
        }
    }
}
