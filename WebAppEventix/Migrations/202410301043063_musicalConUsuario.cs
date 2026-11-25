namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class musicalConUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musicals", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Musicals", "UserId");
            AddForeignKey("dbo.Musicals", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Musicals", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Musicals", new[] { "UserId" });
            DropColumn("dbo.Musicals", "UserId");
        }
    }
}
