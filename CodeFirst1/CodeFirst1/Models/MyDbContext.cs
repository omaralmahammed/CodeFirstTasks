using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
 
namespace CodeFirst1.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("CodeFirstEntities")
        {
        
        }
        private DbSet<Teacher> Teacher { get; set; }

        private DbSet<Student> Student { get; set; }

        private DbSet<Assignments> Assignments { get; set; }
    }
}