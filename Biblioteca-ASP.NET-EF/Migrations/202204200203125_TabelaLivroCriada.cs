namespace Biblioteca_ASP.NET_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaLivroCriada : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livroes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false),
                        Autor = c.String(nullable: false),
                        Categoria = c.String(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Sinopse = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Livroes");
        }
    }
}
