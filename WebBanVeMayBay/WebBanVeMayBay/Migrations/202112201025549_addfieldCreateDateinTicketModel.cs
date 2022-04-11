namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfieldCreateDateinTicketModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "CreateDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "CreateDate");
        }
    }
}
