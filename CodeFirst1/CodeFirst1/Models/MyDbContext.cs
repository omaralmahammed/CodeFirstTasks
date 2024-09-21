using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
 
namespace CodeFirst1.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentDetail> StudentDetails { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public MyDbContext() : base("CodeFirstEntities")
        {
        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();


            // One-to-One relationship between Student and StudentDetails
            //modelBuilder.Entity<Student>()
            //    .HasOptional(s => s.Detail)  // Student can have one or zero details
            //    .WithRequired(sd => sd.Students);     // StudentDetails must have a Student

            
            //base.OnModelCreating(modelBuilder);
        }



    }



}