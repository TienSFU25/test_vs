namespace AnotherTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "MigrateThis", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "MigrateThis");
        }
    }
}
