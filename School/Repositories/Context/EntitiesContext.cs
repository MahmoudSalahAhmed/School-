using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("name=ArmySchool")
        { }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Field> Fields { get; set; }
        public virtual DbSet<Governate> Governates { get; set; }
        public virtual DbSet<Neighborhood> Neighborhoods { get; set; }
        public virtual DbSet<StudentTeacher> StudentTeachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new TeacherConfiguration());
            modelBuilder.Configurations.Add(new FieldConfiguration());
            modelBuilder.Configurations.Add(new GovernateConfiguration());
            modelBuilder.Configurations.Add(new NeighborhoodConfiguration());
            modelBuilder.Configurations.Add(new StudentTeacherConfiguration());
        }
    }
}
