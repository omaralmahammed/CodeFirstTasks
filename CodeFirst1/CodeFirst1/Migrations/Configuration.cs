namespace CodeFirst1.Migrations
{
    using CodeFirst1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst1.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst1.Models.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Students.AddOrUpdate(
            p => p.Name, 
            new Student { Name = "Student A", Class = "A" },
            new Student { Name = "Student B", Class = "B" },
            new Student { Name = "Student C", Class = "A" }
        );

            context.Teachers.AddOrUpdate(
             p => p.Id,
             new Teacher {Id=2, Name = "Khalid" }

       );
        }
    }
}
