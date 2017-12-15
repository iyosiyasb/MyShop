namespace MyShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Address", c => c.String(maxLength: 100));
            AlterColumn("dbo.Employees", "Email", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Email", c => c.String(maxLength: 50));
            DropColumn("dbo.Employees", "Address");
        }
    }
}
