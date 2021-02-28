namespace E_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setPropsOptionas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            AlterColumn("dbo.OrderDetails", "ProductId", c => c.Int());
            CreateIndex("dbo.OrderDetails", "ProductId");
            AddForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            AlterColumn("dbo.OrderDetails", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.OrderDetails", "ProductId");
            AddForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
