namespace codeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblstates",
                c => new
                    {
                        state_id = c.Int(nullable: false, identity: true),
                        state_name = c.String(),
                    })
                .PrimaryKey(t => t.state_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblstates");
        }
    }
}
