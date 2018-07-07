namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipRecords : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET MembershipTypeName='Pay as You Go' WHERE Id=1");
            Sql("Update MembershipTypes SET MembershipTypeName='Monthly' WHERE Id=2");
            Sql("Update MembershipTypes SET MembershipTypeName='Quarterly' WHERE Id=3");
            Sql("Update MembershipTypes SET MembershipTypeName='Yearly' WHERE Id=4");
          
        }
        
        public override void Down()
        {
        }
    }
}
