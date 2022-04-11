namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaaaaa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Complains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Detail = c.String(),
                        ClientName = c.String(),
                        CCCD = c.String(),
                        PhoneNumber = c.String(),
                        CreateSend = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Complains");
        }
    }
}
