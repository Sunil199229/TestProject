namespace dynamicField.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPL_ThirdClassClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PL_ThirdClass",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        mobno = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PL_ThirdClass");
        }
    }
}
