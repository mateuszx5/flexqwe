namespace Flex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeASPUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.AspNetUsers", "Company", c => c.String());
            AddColumn("dbo.AspNetUsers", "NIP", c => c.String());
        }
        
        public override void Down()
        {
 
        }
    }
}
