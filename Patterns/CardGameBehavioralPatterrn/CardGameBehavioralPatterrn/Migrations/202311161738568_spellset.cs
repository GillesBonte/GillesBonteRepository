namespace CardGameBehavioralPatterrn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class spellset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Spells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Damage = c.Int(nullable: false),
                        Name = c.String(),
                        Cost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Spells");
        }
    }
}
