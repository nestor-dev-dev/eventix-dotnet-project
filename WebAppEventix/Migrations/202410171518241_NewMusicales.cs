namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMusicales : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musicals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false),
                        Sinopsis = c.String(),
                        ActoresPrincipales = c.String(),
                        Ciudad = c.String(nullable: false),
                        Lugar = c.String(),
                        Productor = c.String(),
                        DiaDelEspectador = c.Boolean(),
                        FechaHora = c.DateTime(),
                        DuracionEstimada = c.Int(),
                        PrecioMinimo = c.Single(),
                        PrecioMedio = c.Single(),
                        PrecioMaximo = c.Single(),
                        DescripcionPrecios = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musicals");
        }
    }
}
