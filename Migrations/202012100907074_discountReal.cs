namespace E_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discountReal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderDetails", "Discount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderDetails", "Discount", c => c.Int(nullable: false));
        }
    }
}
