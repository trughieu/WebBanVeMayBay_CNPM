namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableBill : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TicketId = c.Int(nullable: false),
                        PlanId = c.Int(nullable: false),
                        PlanName = c.String(),
                        ClientId = c.String(nullable: false),
                        ClientName = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        Date = c.String(),
                        Time = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bills");
        }
    }
}
