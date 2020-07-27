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
    public class GovernateService
    {
        UnitOfWork unitOfWork;
        Generic<Governate> GovernateRepo;
        public GovernateService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            GovernateRepo = unitOfWork.GovernateRepo;
        }
        public GovernateEditViewModel Add(GovernateEditViewModel GovernateEditViewModel)
        {
            Governate Governate = GovernateRepo.Add(GovernateEditViewModel.ToModel());
            unitOfWork.commit();
            return Governate.ToEditableViewModel();
        }
        public GovernateEditViewModel Update(GovernateEditViewModel GovernateEditViewModel)
        {
            Governate Governate = GovernateRepo.Update(GovernateEditViewModel.ToModel());
            unitOfWork.commit();
            return Governate.ToEditableViewModel();
        }
        public void Remove(int id)
        {
            GovernateRepo.Remove(GovernateRepo.GetByID(id));
            unitOfWork.commit();
        }
        public IEnumerable<GovernateViewModel> Get(int id)
        {
            return GovernateRepo.Get(i => i.ID == id).ToList().Select(i => i.ToViewModel());
        }
        public IEnumerable<GovernateViewModel> GetAll()
        {
            return GovernateRepo.GetAll().ToList().Select(i => i.ToViewModel());
        }
        public GovernateViewModel GetByID(int id)
        {
            return GovernateRepo.GetByID(id).ToViewModel();
        }
    }
}
