using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace tablesmock
{
    public class SchoolDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=localhost;Database=Demo;User Id=sa;Password=admin!@#123;");
        }
        public DbSet<Parent> Parent { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentPoints> StudentPoints { get; set; }
        public DbSet<StudentParent> StudentParent { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentParent>()
                 .HasKey(bc => new { bc.StudentId, bc.ParentId });
            modelBuilder.Entity<StudentParent>()
                .HasOne(bc => bc.Parent)
                .WithMany(c=>c.Students)
                .HasForeignKey(bc => bc.ParentId);
            modelBuilder.Entity<StudentParent>()
                .HasOne(bc => bc.Student)
                .WithMany(c=>c.Parents)
                .HasForeignKey(bc => bc.StudentId);
        }
    }

}
