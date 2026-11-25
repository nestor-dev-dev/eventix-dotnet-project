namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ObrasTeatroconUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ObrasTeatroes", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.ObrasTeatroes", "UserId");
            AddForeignKey("dbo.ObrasTeatroes", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ObrasTeatroes", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.ObrasTeatroes", new[] { "UserId" });
            DropColumn("dbo.ObrasTeatroes", "UserId");
        }
    }
}
