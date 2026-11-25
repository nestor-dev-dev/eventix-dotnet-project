namespace WebAppEventix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewOpiniones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Opiniones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Entrada = c.Int(nullable: false),
                        Voto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Opiniones");
        }
    }
}
