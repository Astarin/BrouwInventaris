namespace BrouwInventaris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmyprop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artikels", "MyProperty", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artikels", "MyProperty");
        }
    }
}
