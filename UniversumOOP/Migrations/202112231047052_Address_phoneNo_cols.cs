namespace UniversumOOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Address_phoneNo_cols : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Costumers", "Address", c => c.String());
            AddColumn("dbo.Costumers", "PhoneNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Costumers", "PhoneNo");
            DropColumn("dbo.Costumers", "Address");
        }
    }
}
