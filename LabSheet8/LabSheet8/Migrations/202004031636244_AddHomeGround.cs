namespace LabSheet8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHomeGround : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "HomeGround", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "HomeGround");
        }
    }
}
