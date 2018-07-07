namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate,MembershipTypeName)VALUES(21,0,0,0,'Pay as You Go')");
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate,MembershipTypeName)VALUES(22,30,1,10,'Monthly')");
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate,MembershipTypeName)VALUES(23,90,3,15,'Quarterly')");
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate,MembershipTypeName)VALUES(24,300,12,20,'Yearly')");  
        }
        
        public override void Down()
        {
        }
    }
}
