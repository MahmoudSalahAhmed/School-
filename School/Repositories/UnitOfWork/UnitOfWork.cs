using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UnitOfWork
    {
        private EntitiesContext context;
        public Generic<Admin> AdminRepo { get; set; }
        public Generic<Teacher> TeacherRepo { get; set; }
        public Generic<Student> StudentRepo { get; set; }
        public Generic<StudentTeacher> StudentTeacherRepo { get; set; }
        public Generic<Field> FieldRepo { get; set; }
        public Generic<Governate> GovernateRepo { get; set; }
        public Generic<Neighborhood> NeighborhoodRepo { get; set; }

        /////////////////
        public UnitOfWork(
         EntitiesContext _context,
         Generic<Admin> adminRepo,
         Generic<Teacher> teacherRepo,
         Generic<Student> studentRepo,
         Generic<StudentTeacher> studentTeacherRepo,
         Generic<Governate> governateRepo,
         Generic<Neighborhood> neighborhoodRepo,
         Generic<Field> fieldRepo
         )
        {
            context = _context;

            StudentRepo = studentRepo;
            StudentRepo.Context = context;

            AdminRepo = adminRepo;
            AdminRepo.Context = context;

            TeacherRepo = teacherRepo;
            TeacherRepo.Context = context;

            StudentTeacherRepo = studentTeacherRepo;
            StudentTeacherRepo.Context = context;

            GovernateRepo = governateRepo;
            GovernateRepo.Context = context;

            NeighborhoodRepo = neighborhoodRepo;
            NeighborhoodRepo.Context = context;

            FieldRepo = fieldRepo;
            FieldRepo.Context = context;
            
        }

        public int commit()
        {
            return context.SaveChanges();
        }
    }
}
