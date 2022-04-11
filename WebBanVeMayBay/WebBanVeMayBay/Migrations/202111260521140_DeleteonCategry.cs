namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteonCategry : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "DateTime");
            DropColumn("dbo.Categories", "MidAir");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "MidAir", c => c.String());
            AddColumn("dbo.Categories", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
