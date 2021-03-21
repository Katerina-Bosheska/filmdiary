namespace itproekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postertomovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Poster", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Poster");
        }
    }
}
