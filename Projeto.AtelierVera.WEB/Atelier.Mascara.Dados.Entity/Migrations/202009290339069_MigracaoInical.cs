namespace Atelier.Mascara.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInical : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoMascara",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Tecido = c.String(nullable: false, maxLength: 50),
                        Cor = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(nullable: false, maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoMascara");
        }
    }
}
