namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RenameColumnDurationInMonthToPlural : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            Sql("UPDATE dbo.MembershipTypes SET DurationInMonths = DurationInMonth");
            DropColumn("dbo.MembershipTypes", "DurationInMonth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DurationInMonth", c => c.Byte(nullable: false));
            Sql("UPDATE dbo.MembershipTypes SET DurationInMonth = DurationInMonths");
            DropColumn("dbo.MembershipTypes", "DurationInMonths");
        }
    }
}
