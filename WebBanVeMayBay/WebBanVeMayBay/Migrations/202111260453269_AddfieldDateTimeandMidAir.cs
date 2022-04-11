namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddfieldDateTimeandMidAir : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "MidAir", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "MidAir");
            DropColumn("dbo.Products", "DateTime");
        }
    }
}
