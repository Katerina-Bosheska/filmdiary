namespace itproekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class othertables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieActivities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Action = c.String(),
                        Movie_ID = c.Int(),
                        Profile_Username = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movies", t => t.Movie_ID)
                .ForeignKey("dbo.Profiles", t => t.Profile_Username)
                .Index(t => t.Movie_ID)
                .Index(t => t.Profile_Username);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Year = c.String(nullable: false),
                        Director = c.String(nullable: false),
                        Cast = c.String(nullable: false),
                        Genre = c.String(nullable: false),
                        Rating = c.String(nullable: false),
                        Likes = c.Int(nullable: false),
                        Watches = c.Int(nullable: false),
                        Profile_Username = c.String(maxLength: 128),
                        Profile_Username1 = c.String(maxLength: 128),
                        Profile_Username2 = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Profiles", t => t.Profile_Username)
                .ForeignKey("dbo.Profiles", t => t.Profile_Username1)
                .ForeignKey("dbo.Profiles", t => t.Profile_Username2)
                .Index(t => t.Profile_Username)
                .Index(t => t.Profile_Username1)
                .Index(t => t.Profile_Username2);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Picture = c.String(),
                        Bio = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReviewText = c.String(nullable: false),
                        Rating = c.String(),
                        Likes = c.Int(nullable: false),
                        Movie_ID = c.Int(),
                        Writer_Username = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movies", t => t.Movie_ID)
                .ForeignKey("dbo.Profiles", t => t.Writer_Username)
                .Index(t => t.Movie_ID)
                .Index(t => t.Writer_Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieActivities", "Profile_Username", "dbo.Profiles");
            DropForeignKey("dbo.Movies", "Profile_Username2", "dbo.Profiles");
            DropForeignKey("dbo.Movies", "Profile_Username1", "dbo.Profiles");
            DropForeignKey("dbo.Reviews", "Writer_Username", "dbo.Profiles");
            DropForeignKey("dbo.Reviews", "Movie_ID", "dbo.Movies");
            DropForeignKey("dbo.Movies", "Profile_Username", "dbo.Profiles");
            DropForeignKey("dbo.MovieActivities", "Movie_ID", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "Writer_Username" });
            DropIndex("dbo.Reviews", new[] { "Movie_ID" });
            DropIndex("dbo.Movies", new[] { "Profile_Username2" });
            DropIndex("dbo.Movies", new[] { "Profile_Username1" });
            DropIndex("dbo.Movies", new[] { "Profile_Username" });
            DropIndex("dbo.MovieActivities", new[] { "Profile_Username" });
            DropIndex("dbo.MovieActivities", new[] { "Movie_ID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Profiles");
            DropTable("dbo.Movies");
            DropTable("dbo.MovieActivities");
        }
    }
}
