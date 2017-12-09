namespace MyShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class username : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CompanyName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "CompanyName");
        }
    }
}
