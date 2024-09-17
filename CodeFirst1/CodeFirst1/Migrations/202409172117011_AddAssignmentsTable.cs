﻿using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Data.Entity;

namespace CodeFirst1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAssignmentsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Assignments");
        }
    }
}
