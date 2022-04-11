namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WeekReports", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WeekReports", "Name", c => c.String(nullable: false));
        }
    }
}
