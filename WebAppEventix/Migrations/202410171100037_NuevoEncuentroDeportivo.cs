namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevoEncuentroDeportivo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EncuentrosDeportivos",
                c => new
                    {
                        EncuentrosDeportivosID = c.Int(nullable: false, identity: true),
                        Deporte = c.String(nullable: false),
                        TituloPartido = c.String(nullable: false),
                        EquipoLocal = c.String(),
                        EquipoVisitante = c.String(),
                        Ciudad = c.String(),
                        Lugar = c.String(),
                        FechaHora = c.DateTime(nullable: false),
                        PrecioMinimo = c.Double(nullable: false),
                        PrecioMedio = c.Double(nullable: false),
                        PrecioMaximo = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.EncuentrosDeportivosID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EncuentrosDeportivos");
        }
    }
}
