namespace E_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discountFloat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderDetails", "Discount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderDetails", "Discount", c => c.Double(nullable: false));
        }
    }
}
