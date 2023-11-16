namespace CardGameBehavioralPatterrn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Minions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Attack = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
                        Name = c.String(),
                        Cost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Minions");
        }
    }
}
