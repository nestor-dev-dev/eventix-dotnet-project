namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProblemasDislexia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Conciertoes", "Descripcion", c => c.String());
            AddColumn("dbo.Conciertoes", "Ciudad", c => c.String(nullable: false));
            AlterColumn("dbo.Conciertoes", "Fecha_Hora", c => c.DateTime(nullable: false));
            DropColumn("dbo.Conciertoes", "Desccripcion");
            DropColumn("dbo.Conciertoes", "Cidudad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Conciertoes", "Cidudad", c => c.String(nullable: false));
            AddColumn("dbo.Conciertoes", "Desccripcion", c => c.String());
            AlterColumn("dbo.Conciertoes", "Fecha_Hora", c => c.Int(nullable: false));
            DropColumn("dbo.Conciertoes", "Ciudad");
            DropColumn("dbo.Conciertoes", "Descripcion");
        }
    }
}
