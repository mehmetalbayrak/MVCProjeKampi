namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_author_status_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "AuthorStatus");
        }
    }
}
