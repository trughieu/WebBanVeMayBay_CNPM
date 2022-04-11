namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateclientid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "ClientId", c => c.String(nullable: false));
            AddColumn("dbo.Tickets", "ClientName", c => c.String(nullable: false));
            DropColumn("dbo.Tickets", "IdClient");
            DropColumn("dbo.Tickets", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Tickets", "IdClient", c => c.String(nullable: false));
            DropColumn("dbo.Tickets", "ClientName");
            DropColumn("dbo.Tickets", "ClientId");
        }
    }
}
