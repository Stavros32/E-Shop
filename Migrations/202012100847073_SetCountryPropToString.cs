namespace E_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetCountryPropToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Country", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Country", c => c.Int(nullable: false));
        }
    }
}
