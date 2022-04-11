namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1234 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "PlanId", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "PlanName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "PlanName");
            DropColumn("dbo.Tickets", "PlanId");
        }
    }
}
