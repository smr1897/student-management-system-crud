global using Microsoft.EntityFrameworkCore;
using CRUDApplication.Models;

namespace CRUDApplication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=StudentManagementSystemDB;Trusted_Connection=true;");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<AllocateSubject> AllocateSubjects { get; set; }
        public DbSet<AllocateClassRoom> AllocateClassRooms { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AllocateSubject>().HasKey(sa => sa.SubjectAllocationId);
            //modelBuilder.Entity<AllocateSubject>().HasOne(sa => sa.Teacher).WithMany(t => t.SubjectAllocations).HasForeignKey(sa => sa.TeacherID);
            //modelBuilder.Entity<AllocateSubject>().HasOne(sa => sa.Subject).WithMany(s => s.TeacherAllocations).HasForeignKey(sa => sa.SubjectId);

            //modelBuilder.Entity<AllocateClassRoom>().HasKey(ca => ca.ClassroomAllocationId);
            //modelBuilder.Entity<AllocateClassRoom>().HasOne(ca => ca.Teacher).WithMany(t => t.ClassroomAllocations).HasForeignKey(ca => ca.TeacherID);
            //modelBuilder.Entity<AllocateClassRoom>().HasOne(ca => ca.classRoom).WithMany(c => c.TeacherAllocations).HasForeignKey(ca => ca.ClassRoomId);

        }
    }
}
