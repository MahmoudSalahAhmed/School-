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
    public class NeighborhoodService
    {
        UnitOfWork unitOfWork;
        Generic<Neighborhood> NeighborhoodRepo;
        public NeighborhoodService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            NeighborhoodRepo = unitOfWork.NeighborhoodRepo;
        }
        public NeighborhoodEditViewModel Add(NeighborhoodEditViewModel NeighborhoodEditViewModel)
        {
            Neighborhood Neighborhood = NeighborhoodRepo.Add(NeighborhoodEditViewModel.ToModel());
            unitOfWork.commit();
            return Neighborhood.ToEditableViewModel();
        }
        public NeighborhoodEditViewModel Update(NeighborhoodEditViewModel NeighborhoodEditViewModel)
        {
            Neighborhood Neighborhood = NeighborhoodRepo.Update(NeighborhoodEditViewModel.ToModel());
            unitOfWork.commit();
            return Neighborhood.ToEditableViewModel();
        }
        public void Remove(int id)
        {
            NeighborhoodRepo.Remove(NeighborhoodRepo.GetByID(id));
            unitOfWork.commit();
        }
        public IEnumerable<NeighborhoodViewModel> Get(int id)
        {
            return NeighborhoodRepo.Get(i => i.ID == id).ToList().Select(i => i.ToViewModel());
        }
        public IEnumerable<NeighborhoodViewModel> GetAll()
        {
            return NeighborhoodRepo.GetAll().ToList().Select(i => i.ToViewModel());
        }
        public NeighborhoodViewModel GetByID(int id)
        {
            return NeighborhoodRepo.GetByID(id).ToViewModel();
        }
    }
}
