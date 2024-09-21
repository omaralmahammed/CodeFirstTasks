namespace CodeFirst1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTables : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.StudentDetail", "StudantId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentDetail", "StudantId", c => c.Int(nullable: false));
        }
    }
}
