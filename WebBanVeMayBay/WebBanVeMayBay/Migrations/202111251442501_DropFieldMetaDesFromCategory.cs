namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropFieldMetaDesFromCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Created_By", c => c.Int(nullable: false));
            DropColumn("dbo.Categories", "MetaDes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "MetaDes", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Created_By", c => c.Int());
        }
    }
}
