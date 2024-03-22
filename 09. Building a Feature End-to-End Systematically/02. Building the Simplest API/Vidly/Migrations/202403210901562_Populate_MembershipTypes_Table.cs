namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Populate_MembershipTypes_Table : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) " +
                "VALUES " +
                "(1, 'Pay as You Go', 0, 0, 0), " +
                "(2, 'Monthly', 30, 1, 10), " +
                "(3, 'Quarterly', 90, 3, 15), " +
                "(4, 'Annual', 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
