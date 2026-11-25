namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfConcierto : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Conciertoes", "Cantante", c => c.String(nullable: false));
            AlterColumn("dbo.Conciertoes", "Titulo", c => c.String(nullable: false));
            AlterColumn("dbo.Conciertoes", "Desccripcion", c => c.String());
            AlterColumn("dbo.Conciertoes", "Cidudad", c => c.String(nullable: false));
            AlterColumn("dbo.Conciertoes", "Lugar", c => c.String());
            AlterColumn("dbo.Conciertoes", "PrcMin", c => c.Single(nullable: false));
            AlterColumn("dbo.Conciertoes", "PrcMed", c => c.Single(nullable: false));
            AlterColumn("dbo.Conciertoes", "PrcMax", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Conciertoes", "PrcMax", c => c.Int(nullable: false));
            AlterColumn("dbo.Conciertoes", "PrcMed", c => c.Int(nullable: false));
            AlterColumn("dbo.Conciertoes", "PrcMin", c => c.Int(nullable: false));
            AlterColumn("dbo.Conciertoes", "Lugar", c => c.Int(nullable: false));
            AlterColumn("dbo.Conciertoes", "Cidudad", c => c.Int(nullable: false));
            AlterColumn("dbo.Conciertoes", "Desccripcion", c => c.Int(nullable: false));
            AlterColumn("dbo.Conciertoes", "Titulo", c => c.Int(nullable: false));
            AlterColumn("dbo.Conciertoes", "Cantante", c => c.Int(nullable: false));
        }
    }
}
