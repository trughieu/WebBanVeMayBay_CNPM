namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedbproduct1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "BreakTime", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "PlanTo", c => c.String());
            AddColumn("dbo.Products", "PlanFrom", c => c.String());
            AddColumn("dbo.Products", "Seat1", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Seat2", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "OnAir", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Slug");
            DropColumn("dbo.Products", "MetaKey");
            DropColumn("dbo.Products", "MetaDes");
            DropColumn("dbo.Products", "Img");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Img", c => c.String());
            AddColumn("dbo.Products", "MetaDes", c => c.String(nullable: false));
            AddColumn("dbo.Products", "MetaKey", c => c.String(nullable: false));
            AddColumn("dbo.Products", "Slug", c => c.String());
            DropColumn("dbo.Products", "OnAir");
            DropColumn("dbo.Products", "Seat2");
            DropColumn("dbo.Products", "Seat1");
            DropColumn("dbo.Products", "PlanFrom");
            DropColumn("dbo.Products", "PlanTo");
            DropColumn("dbo.Products", "BreakTime");
        }
    }
}
