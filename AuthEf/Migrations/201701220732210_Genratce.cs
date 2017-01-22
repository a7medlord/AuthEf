namespace AuthEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genratce : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LasLogin", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Plonder", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Plonder");
            DropColumn("dbo.AspNetUsers", "LasLogin");
        }
    }
}
