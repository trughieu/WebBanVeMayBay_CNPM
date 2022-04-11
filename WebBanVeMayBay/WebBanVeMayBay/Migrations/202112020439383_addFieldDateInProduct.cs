﻿namespace WebBanVeMayBay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFieldDateInProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Date");
        }
    }
}
