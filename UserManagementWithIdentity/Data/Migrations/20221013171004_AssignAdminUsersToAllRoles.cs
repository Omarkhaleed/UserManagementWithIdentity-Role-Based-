using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class AssignAdminUsersToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into[Security].[UserRoles] (UserId, RoleId) SELECT '3aaf42cc-84c4-4853-8903-0e4f8100795f',Id FROM[Security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM[Security].[UserRoles] WHERE userId = '3aaf42cc-84c4-4853-8903-0e4f8100795f'");
        }
    }
}
