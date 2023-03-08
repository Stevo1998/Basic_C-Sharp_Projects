namespace Final_Challenge_Assignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteListColumn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Student_Id", "dbo.Students");
            DropIndex("dbo.Students", new[] { "Student_Id" });
            DropColumn("dbo.Students", "Student_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Student_Id", c => c.Int());
            CreateIndex("dbo.Students", "Student_Id");
            AddForeignKey("dbo.Students", "Student_Id", "dbo.Students", "Id");
        }
    }
}
