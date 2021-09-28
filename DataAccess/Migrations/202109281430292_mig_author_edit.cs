namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_author_edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorAbout", c => c.String(maxLength: 100));
            AlterColumn("dbo.Authors", "AuthorEmail", c => c.String(maxLength: 200));
            AlterColumn("dbo.Authors", "AuthorPassword", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "AuthorPassword", c => c.String(maxLength: 20));
            AlterColumn("dbo.Authors", "AuthorEmail", c => c.String(maxLength: 50));
            DropColumn("dbo.Authors", "AuthorAbout");
        }
    }
}
