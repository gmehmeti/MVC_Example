namespace UniversumOOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameIsNotNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Costumers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Costumers", "Place", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Costumers", "Place", c => c.String());
            AlterColumn("dbo.Costumers", "Name", c => c.String());
        }
    }
}
