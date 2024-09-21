namespace CodeFirst1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oneTomanyTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Course", "Teachers_Id", c => c.Int());
            CreateIndex("dbo.Course", "Teachers_Id");
            AddForeignKey("dbo.Course", "Teachers_Id", "dbo.Teacher", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Course", "Teachers_Id", "dbo.Teacher");
            DropIndex("dbo.Course", new[] { "Teachers_Id" });
            DropColumn("dbo.Course", "Teachers_Id");
        }
    }
}
