namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevoObrasTeatro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ObrasTeatroes",
                c => new
                    {
                        ObrasTeatroId = c.Int(nullable: false, identity: true),
                        TituloObra = c.String(nullable: false),
                        Sinopsis = c.String(),
                        ActoresPrincipales = c.String(),
                        Ciudad = c.String(nullable: false),
                        Lugar = c.String(),
                        Productor = c.String(),
                        DiaDelEspectador = c.Boolean(nullable: false),
                        FechaHora = c.DateTime(nullable: false),
                        DuracionEstimada = c.Int(nullable: false),
                        PrecioMinimo = c.Single(nullable: false),
                        PrecioMedio = c.Single(nullable: false),
                        PrecioMaximo = c.Single(nullable: false),
                        DescripcionPrecios = c.String(),
                    })
                .PrimaryKey(t => t.ObrasTeatroId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ObrasTeatroes");
        }
    }
}
