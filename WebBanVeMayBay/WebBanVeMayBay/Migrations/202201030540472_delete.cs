namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Contacts");
            DropTable("dbo.Menus");
            DropTable("dbo.MonthReports");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.Posts");
            DropTable("dbo.PreReports");
            DropTable("dbo.Sliders");
            DropTable("dbo.Topics");
            DropTable("dbo.YearReports");
        }
        
        public override void Down()
        {
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
                        Created_By = c.Int(),
                        Created_At = c.DateTime(),
                        Update_By = c.Int(),
                        Update_At = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Slug = c.String(),
                        ParentID = c.Int(nullable: false),
                        Orders = c.Int(nullable: false),
                        MetaKey = c.String(nullable: false),
                        MetaDes = c.String(nullable: false),
                        Created_By = c.Int(),
                        Created_At = c.DateTime(),
                        Update_By = c.Int(),
                        Update_At = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Link = c.String(nullable: false),
                        Img = c.String(),
                        Orders = c.Int(nullable: false),
                        Created_By = c.Int(),
                        Created_At = c.DateTime(),
                        Update_By = c.Int(),
                        Update_At = c.DateTime(),
                        Status = c.Int(nullable: false),
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
                        Created_By = c.Int(),
                        Created_At = c.DateTime(),
                        Update_By = c.Int(),
                        Update_At = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TopicID = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        Slug = c.String(),
                        Detail = c.String(nullable: false),
                        MetaKey = c.String(nullable: false),
                        MetaDes = c.String(nullable: false),
                        Img = c.String(),
                        Created_By = c.Int(),
                        Created_At = c.DateTime(),
                        Update_By = c.Int(),
                        Update_At = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Note = c.String(),
                        Created_At = c.DateTime(),
                        Update_By = c.Int(),
                        Update_At = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Quality = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        Created_By = c.Int(),
                        Created_At = c.DateTime(),
                        Update_By = c.Int(),
                        Update_At = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Link = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        TableID = c.Int(nullable: false),
                        ParentID = c.Int(nullable: false),
                        Orders = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        Created_By = c.Int(nullable: false),
                        Created_At = c.DateTime(),
                        Update_By = c.Int(),
                        Update_At = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
