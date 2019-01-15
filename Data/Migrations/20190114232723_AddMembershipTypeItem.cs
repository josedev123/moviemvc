using Microsoft.EntityFrameworkCore.Migrations;

namespace moviemvc.Data.Migrations
{
    public partial class AddMembershipTypeItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MembershipType",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    SignUpFee = table.Column<short>(nullable: false),
                    DurationInMonths = table.Column<byte>(nullable: false),
                    DiscountRate = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MembershipType");
        }
    }
}
