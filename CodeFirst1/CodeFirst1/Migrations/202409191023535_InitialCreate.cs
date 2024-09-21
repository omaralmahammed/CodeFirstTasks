namespace CodeFirst1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentDetail", "Students_Id", "dbo.Student");
            DropIndex("dbo.StudentDetail", new[] { "Students_Id" });
            DropColumn("dbo.StudentDetail", "Students_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentDetail", "Students_Id", c => c.Int());
            CreateIndex("dbo.StudentDetail", "Students_Id");
            AddForeignKey("dbo.StudentDetail", "Students_Id", "dbo.Student", "Id");
        }
    }
}
