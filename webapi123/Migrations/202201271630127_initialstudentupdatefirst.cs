namespace webapi123.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialstudentupdatefirst : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "age", c => c.Int());
            AlterColumn("dbo.Students", "studentclass", c => c.Int());
            AlterColumn("dbo.Students", "TeacherId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "TeacherId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "studentclass", c => c.String());
            AlterColumn("dbo.Students", "age", c => c.String());
        }
    }
}
