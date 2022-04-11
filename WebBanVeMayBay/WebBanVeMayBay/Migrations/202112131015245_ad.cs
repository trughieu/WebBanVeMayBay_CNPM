namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Date", c => c.String());
            AddColumn("dbo.Tickets", "Time", c => c.String());
            DropColumn("dbo.Tickets", "DateTime");
            DropColumn("dbo.Tickets", "OnAir");
            DropColumn("dbo.Tickets", "TicketClass");
            DropColumn("dbo.Tickets", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Status", c => c.String());
            AddColumn("dbo.Tickets", "TicketClass", c => c.String());
            AddColumn("dbo.Tickets", "OnAir", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Tickets", "Time");
            DropColumn("dbo.Tickets", "Date");
        }
    }
}
