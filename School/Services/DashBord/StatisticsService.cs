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
    public class StatisticsService
    {
        UnitOfWork unitOfWork;
        
        Generic<Teacher> TeacherRepo;
        Generic<Student> StudentRepo;
        Generic<Governate> GovernateRepo;
        Generic<Neighborhood> NeighborhoodRepo;

        public StatisticsService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            NeighborhoodRepo = unitOfWork.NeighborhoodRepo;
            TeacherRepo = unitOfWork.TeacherRepo;
            StudentRepo = unitOfWork.StudentRepo;
            GovernateRepo = unitOfWork.GovernateRepo;
        }

        public StatisticsViewModel GetStatistics()
        {
            StatisticsViewModel report = new StatisticsViewModel();
            report.Neighborhoods = NeighborhoodRepo.GetAll().Count();
            report.Teachers = TeacherRepo.GetAll().Count();
            report.Students = StudentRepo.GetAll().Count();
            report.Governates = GovernateRepo.GetAll().Count();
            return report;
        }
    }
}
