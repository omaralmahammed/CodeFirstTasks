namespace CodeFirst1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudentsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Class", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Class");
        }
    }
}
