namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddfieldMidAir : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "MidAir", c => c.String());
            AlterColumn("dbo.Categories", "Created_By", c => c.Int());
            DropColumn("dbo.Categories", "MetaKey");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "MetaKey", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Created_By", c => c.Int(nullable: false));
            DropColumn("dbo.Categories", "MidAir");
        }
    }
}
