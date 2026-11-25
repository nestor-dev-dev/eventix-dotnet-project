namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredFieldsVisitaTuristica : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VisitaTuristicaGuiadas", "Ciudad", c => c.String(nullable: false));
            AlterColumn("dbo.VisitaTuristicaGuiadas", "TituloRecorrido", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VisitaTuristicaGuiadas", "TituloRecorrido", c => c.String());
            AlterColumn("dbo.VisitaTuristicaGuiadas", "Ciudad", c => c.String());
        }
    }
}
