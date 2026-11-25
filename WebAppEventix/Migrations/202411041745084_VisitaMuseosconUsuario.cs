namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VisitaMuseosconUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EncuentrosDeportivos", "UserID", c => c.String(maxLength: 128));
            AddColumn("dbo.Musicals", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.VisitaMuseos", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.VisitaTuristicaGuiadas", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.EncuentrosDeportivos", "UserID");
            CreateIndex("dbo.Musicals", "UserId");
            CreateIndex("dbo.VisitaMuseos", "UserId");
            CreateIndex("dbo.VisitaTuristicaGuiadas", "UserId");
            AddForeignKey("dbo.EncuentrosDeportivos", "UserID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Musicals", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.VisitaMuseos", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.VisitaTuristicaGuiadas", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VisitaTuristicaGuiadas", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.VisitaMuseos", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Musicals", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.EncuentrosDeportivos", "UserID", "dbo.AspNetUsers");
            DropIndex("dbo.VisitaTuristicaGuiadas", new[] { "UserId" });
            DropIndex("dbo.VisitaMuseos", new[] { "UserId" });
            DropIndex("dbo.Musicals", new[] { "UserId" });
            DropIndex("dbo.EncuentrosDeportivos", new[] { "UserID" });
            DropColumn("dbo.VisitaTuristicaGuiadas", "UserId");
            DropColumn("dbo.VisitaMuseos", "UserId");
            DropColumn("dbo.Musicals", "UserId");
            DropColumn("dbo.EncuentrosDeportivos", "UserID");
        }
    }
}
