namespace mvcGITBranchWalkthru.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GitAccounts", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.GitAccounts", "Country");
        }
    }
}
