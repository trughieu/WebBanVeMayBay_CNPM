namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditFieldCCCDtoClientIDinComplainTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Complains", "ClientId", c => c.String());
            DropColumn("dbo.Complains", "CCCD");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Complains", "CCCD", c => c.String());
            DropColumn("dbo.Complains", "ClientId");
        }
    }
}
