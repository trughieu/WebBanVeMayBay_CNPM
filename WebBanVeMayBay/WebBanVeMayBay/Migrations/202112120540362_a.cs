namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Time");
            DropColumn("dbo.Products", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "Time", c => c.DateTime(nullable: false));
        }
    }
}
