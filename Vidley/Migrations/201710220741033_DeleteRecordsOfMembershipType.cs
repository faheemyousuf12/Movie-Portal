namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteRecordsOfMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Delete From MembershipTypes where Id!=32908723498");
        }
        
        public override void Down()
        {
        }
    }
}
