namespace E_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discOptional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderDetails", "Discount", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderDetails", "Discount", c => c.Single(nullable: false));
        }
    }
}
