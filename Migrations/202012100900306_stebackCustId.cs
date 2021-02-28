namespace E_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stebackCustId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Customer_Id" });
            DropColumn("dbo.Orders", "CustomerId");
            RenameColumn(table: "dbo.Orders", name: "Customer_Id", newName: "CustomerId");
            AlterColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "OrderDate", c => c.DateTime());
            AlterColumn("dbo.Orders", "RequiredDate", c => c.DateTime());
            AlterColumn("dbo.Orders", "ShippedDate", c => c.DateTime());
            AlterColumn("dbo.Orders", "ShipVia", c => c.Int());
            AlterColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "CustomerId");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            AlterColumn("dbo.Orders", "CustomerId", c => c.Int());
            AlterColumn("dbo.Orders", "ShipVia", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "ShippedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "RequiredDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "CustomerId", c => c.String());
            RenameColumn(table: "dbo.Orders", name: "CustomerId", newName: "Customer_Id");
            AddColumn("dbo.Orders", "CustomerId", c => c.String());
            CreateIndex("dbo.Orders", "Customer_Id");
            AddForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
