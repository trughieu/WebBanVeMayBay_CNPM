namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTimeandDateofProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Time", c => c.DateTime(nullable: false));
            DropColumn("dbo.Products", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Products", "Time");
        }
    }
}
