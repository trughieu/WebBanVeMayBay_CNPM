namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedbticket : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdClient = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        OnAir = c.Int(nullable: false),
                        TicketClass = c.String(),
                        Status = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
        }
    }
}
