namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberShipModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShips",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Title = c.String(),
                        DurationInMonths = c.Byte(nullable: false),
                        MemberShipPrice = c.Byte(nullable: false),
                        MemberShipDiscount = c.Byte(nullable: false),
                        ActiveStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MemberShipId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MemberShipId");
            AddForeignKey("dbo.Customers", "MemberShipId", "dbo.MemberShips", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipId", "dbo.MemberShips");
            DropIndex("dbo.Customers", new[] { "MemberShipId" });
            DropColumn("dbo.Customers", "MemberShipId");
            DropTable("dbo.MemberShips");
        }
    }
}
