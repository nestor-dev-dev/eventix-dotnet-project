namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevoVisitaMuseos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VisitaMuseos",
                c => new
                    {
                        VisitaMuseosId = c.Int(nullable: false, identity: true),
                        TituloVisita = c.String(nullable: false),
                        NombreMuseo = c.String(nullable: false),
                        DiasCerrado = c.DateTime(nullable: false),
                        ObrasDestacadas = c.String(),
                        PrecioEntrada = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.VisitaMuseosId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VisitaMuseos");
        }
    }
}
