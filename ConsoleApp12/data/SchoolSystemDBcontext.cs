using ConsoleApp12.models;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12.data
{
    public class SchoolSystemDBcontext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enroll> Enrolls { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database = StudentSystemDB; Trusted_Connection = True; TrustServerCertificate=True;");
        }
    }
}
