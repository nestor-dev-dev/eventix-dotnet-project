namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class visitaturisticaconusuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VisitaTuristicaGuiadas", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.VisitaTuristicaGuiadas", "UserId");
            AddForeignKey("dbo.VisitaTuristicaGuiadas", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VisitaTuristicaGuiadas", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.VisitaTuristicaGuiadas", new[] { "UserId" });
            DropColumn("dbo.VisitaTuristicaGuiadas", "UserId");
        }
    }
}
