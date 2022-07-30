namespace SinglePageApplicationInMVC_UsingJQuery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Telephone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Telephone", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
