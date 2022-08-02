namespace codeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkcity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblcities", "tblcity_city_id", c => c.Int());
            CreateIndex("dbo.tblcities", "tblcity_city_id");
            CreateIndex("dbo.tblemployee", "city_id");
            AddForeignKey("dbo.tblcities", "tblcity_city_id", "dbo.tblcities", "city_id");
            AddForeignKey("dbo.tblemployee", "city_id", "dbo.tblcities", "city_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblemployee", "city_id", "dbo.tblcities");
            DropForeignKey("dbo.tblcities", "tblcity_city_id", "dbo.tblcities");
            DropIndex("dbo.tblemployee", new[] { "city_id" });
            DropIndex("dbo.tblcities", new[] { "tblcity_city_id" });
            DropColumn("dbo.tblcities", "tblcity_city_id");
        }
    }
}
