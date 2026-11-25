namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevoConcierto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conciertoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantante = c.Int(nullable: false),
                        Titulo = c.Int(nullable: false),
                        Desccripcion = c.Int(nullable: false),
                        Cidudad = c.Int(nullable: false),
                        Lugar = c.Int(nullable: false),
                        Fecha_Hora = c.Int(nullable: false),
                        Duracion = c.Int(nullable: false),
                        PrcMin = c.Int(nullable: false),
                        PrcMed = c.Int(nullable: false),
                        PrcMax = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Conciertoes");
        }
    }
}
