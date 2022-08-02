namespace codeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblcities",
                c => new
                    {
                        city_id = c.Int(nullable: false, identity: true),
                        city_name = c.String(),
                    })
                .PrimaryKey(t => t.city_id);
            
            CreateTable(
                "dbo.tblemployee",
                c => new
                    {
                        emp_id = c.Int(nullable: false, identity: true),
                        f_name = c.String(maxLength: 10),
                        salary = c.Int(nullable: false),
                        mobile = c.Decimal(nullable: false, precision: 18, scale: 2),
                        email = c.String(),
                        dob = c.DateTime(),
                        address = c.String(),
                        city_id = c.Int(),
                    })
                .PrimaryKey(t => t.emp_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblemployee");
            DropTable("dbo.tblcities");
        }
    }
}
