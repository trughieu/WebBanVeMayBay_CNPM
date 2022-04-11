namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfieldDateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "DateTime");
        }
    }
}
