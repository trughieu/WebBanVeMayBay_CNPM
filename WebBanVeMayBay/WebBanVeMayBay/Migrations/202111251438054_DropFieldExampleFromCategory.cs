namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropFieldExampleFromCategory : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "CreationTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CreationTime", c => c.DateTime(nullable: false));
        }
    }
}
