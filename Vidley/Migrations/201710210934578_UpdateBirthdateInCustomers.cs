namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdateInCustomers : DbMigration
    {
        public override void Up()
        {
            
            Sql("Update Customers SET Birthdate='06/12/1997' WHERE Id=1");
            Sql("Update Customers SET Birthdate='05/2/1993' WHERE Id=3");
           
        }
        
        public override void Down()
        {
        }
    }
}
