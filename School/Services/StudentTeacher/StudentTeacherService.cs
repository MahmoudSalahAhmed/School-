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
    public class StudentTeacherService
    {
        UnitOfWork unitOfWork;
        Generic<StudentTeacher> StudentTeacherRepo;
        public StudentTeacherService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            StudentTeacherRepo = unitOfWork.StudentTeacherRepo;
        }
        public StudentTeacherEditViewModel Add(StudentTeacherEditViewModel StudentTeacherEditViewModel)
        {
            StudentTeacher StudentTeacher = StudentTeacherRepo.Add(StudentTeacherEditViewModel.ToModel());
            unitOfWork.commit();
            return StudentTeacher.ToEditableViewModel();
        }
        public StudentTeacherEditViewModel Update(StudentTeacherEditViewModel StudentTeacherEditViewModel)
        {
            StudentTeacher StudentTeacher = StudentTeacherRepo.Update(StudentTeacherEditViewModel.ToModel());
            unitOfWork.commit();
            return StudentTeacher.ToEditableViewModel();
        }
        public void Remove(int id)
        {
            StudentTeacherRepo.Remove(StudentTeacherRepo.GetByID(id));
            unitOfWork.commit();
        }
        public IEnumerable<StudentTeacherViewModel> Get(int id)
        {
            return StudentTeacherRepo.Get(i => i.ID == id).ToList().Select(i => i.ToViewModel());
        }
        public IEnumerable<StudentTeacherViewModel> GetAll()
        {
            return StudentTeacherRepo.GetAll().ToList().Select(i => i.ToViewModel());
        }
        public StudentTeacherViewModel GetByID(int id)
        {
            return StudentTeacherRepo.GetByID(id).ToViewModel();
        }
    }
}
