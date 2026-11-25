namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevoVisitaTuristicaGuiada : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VisitaTuristicaGuiadas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ciudad = c.String(nullable: false),
                        TituloRecorrido = c.String(nullable: false),
                        Pago = c.Boolean(),
                        AgenciaTourOperadora = c.String(),
                        Tipo = c.Int(),
                        FechaHora = c.DateTime(),
                        DuracionEstimada = c.Int(),
                        Precio = c.Single(),
                        LugarInicio = c.String(),
                        LugarFin = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VisitaTuristicaGuiadas");
        }
    }
}
