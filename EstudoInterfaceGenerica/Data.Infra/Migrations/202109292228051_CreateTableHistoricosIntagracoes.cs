namespace Data.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableHistoricosIntagracoes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistoricoIntegracaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Score = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataCadastro = c.DateTime(nullable: false),
                        Guid = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HistoricoIntegracaos");
        }
    }
}
