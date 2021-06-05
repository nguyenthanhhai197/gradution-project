using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace eLearning.Core.Data
{
    public class eLearningDbcontext : DbContext
    {
        public eLearningDbcontext(DbContextOptions opt) : base(opt)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lession> Lessions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentLession> StudentLessions { get; set; }
        public DbSet<File> Files { get; set; }
    }
}
