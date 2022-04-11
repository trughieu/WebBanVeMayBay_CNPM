namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDay : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WeekReports", "Day", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WeekReports", "Day", c => c.DateTime(nullable: false));
        }
    }
}
