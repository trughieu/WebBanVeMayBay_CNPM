namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MonthReports", "Created_By", c => c.Int());
            AddColumn("dbo.MonthReports", "Created_At", c => c.DateTime());
            AddColumn("dbo.MonthReports", "Update_By", c => c.Int());
            AddColumn("dbo.MonthReports", "Update_At", c => c.DateTime());
            AddColumn("dbo.PreReports", "Created_By", c => c.Int());
            AddColumn("dbo.PreReports", "Created_At", c => c.DateTime());
            AddColumn("dbo.PreReports", "Update_By", c => c.Int());
            AddColumn("dbo.PreReports", "Update_At", c => c.DateTime());
            AddColumn("dbo.WeekReports", "Created_By", c => c.Int());
            AddColumn("dbo.WeekReports", "Created_At", c => c.DateTime());
            AddColumn("dbo.WeekReports", "Update_By", c => c.Int());
            AddColumn("dbo.WeekReports", "Update_At", c => c.DateTime());
            AddColumn("dbo.YearReports", "Created_By", c => c.Int());
            AddColumn("dbo.YearReports", "Created_At", c => c.DateTime());
            AddColumn("dbo.YearReports", "Update_By", c => c.Int());
            AddColumn("dbo.YearReports", "Update_At", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.YearReports", "Update_At");
            DropColumn("dbo.YearReports", "Update_By");
            DropColumn("dbo.YearReports", "Created_At");
            DropColumn("dbo.YearReports", "Created_By");
            DropColumn("dbo.WeekReports", "Update_At");
            DropColumn("dbo.WeekReports", "Update_By");
            DropColumn("dbo.WeekReports", "Created_At");
            DropColumn("dbo.WeekReports", "Created_By");
            DropColumn("dbo.PreReports", "Update_At");
            DropColumn("dbo.PreReports", "Update_By");
            DropColumn("dbo.PreReports", "Created_At");
            DropColumn("dbo.PreReports", "Created_By");
            DropColumn("dbo.MonthReports", "Update_At");
            DropColumn("dbo.MonthReports", "Update_By");
            DropColumn("dbo.MonthReports", "Created_At");
            DropColumn("dbo.MonthReports", "Created_By");
        }
    }
}
