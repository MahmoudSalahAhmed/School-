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
    public class TeacherService
    {
        UnitOfWork unitOfWork;
        Generic<Teacher> TeacherRepo;
        public TeacherService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            TeacherRepo = unitOfWork.TeacherRepo;
        }
        public TeacherEditViewModel Add(TeacherEditViewModel TeacherEditViewModel)
        {
            Teacher Teacher = TeacherRepo.Add(TeacherEditViewModel.ToModel());
            unitOfWork.commit();
            return Teacher.ToEditableViewModel();
        }
        public TeacherEditViewModel Update(TeacherEditViewModel TeacherEditViewModel)
        {
            Teacher Teacher = TeacherRepo.Update(TeacherEditViewModel.ToModel());
            unitOfWork.commit();
            return Teacher.ToEditableViewModel();
        }
        public void Remove(int id)
        {
            Teacher teach = TeacherRepo.GetByID(id);
            TeacherRepo.Remove(teach);
            unitOfWork.commit();
        }
        public IEnumerable<TeacherViewModel> Get(int id)
        {
            return TeacherRepo.Get(i => i.ID == id).ToList().Select(i => i.ToViewModel());
        }
        public IEnumerable<TeacherViewModel> GetAll()
        {
            return TeacherRepo.GetAll().ToList().Select(i => i.ToViewModel());
        }
        public TeacherViewModel GetByID(int id)
        {
            return TeacherRepo.GetByID(id).ToViewModel();
        }
    }
}
