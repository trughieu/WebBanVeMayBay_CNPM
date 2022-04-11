namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonthReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Day = c.DateTime(nullable: false),
                        Number = c.Int(nullable: false),
                        Revenue = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PreReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Day = c.DateTime(nullable: false),
                        Number = c.Int(nullable: false),
                        Revenue = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeekReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Day = c.DateTime(nullable: false),
                        Number = c.Int(nullable: false),
                        Revenue = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.YearReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Month = c.DateTime(nullable: false),
                        Number = c.Int(nullable: false),
                        Revenue = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.YearReports");
            DropTable("dbo.WeekReports");
            DropTable("dbo.PreReports");
            DropTable("dbo.MonthReports");
        }
    }
}
