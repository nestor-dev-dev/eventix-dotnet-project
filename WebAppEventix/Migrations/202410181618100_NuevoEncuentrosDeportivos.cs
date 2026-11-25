namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevoEncuentrosDeportivos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EncuentrosDeportivos",
                c => new
                    {
                        EncuentrosDeportivosId = c.Int(nullable: false, identity: true),
                        Deporte = c.String(nullable: false),
                        TituloPartido = c.String(nullable: false),
                        EquipoLocal = c.String(),
                        EquipoVisitante = c.String(),
                        Ciudad = c.String(nullable: false),
                        Lugar = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        PrecioMinimo = c.Single(nullable: false),
                        PrecioMedio = c.Single(nullable: false),
                        PrecioMaximo = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.EncuentrosDeportivosId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EncuentrosDeportivos");
        }
    }
}
