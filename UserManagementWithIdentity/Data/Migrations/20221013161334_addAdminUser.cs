using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class addAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [FirstName], [LastName], [ProfilePicture], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES(N'3aaf42cc-84c4-4853-8903-0e4f8100795f', N'omarTohami', N'KhalidElsayed', NULL, N'Admin', N'ADMIN', N'Admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGBZxymnpJ9wnN71l/ugmno/PaY+J38GWm7JRcjzQC3EK4fLojKkhoutYgeIiZLgKA==', N'7SPBI6LLBUDW36M2CTSRFARRLBUSQHUB', N'8f1a6892-342e-4e30-adfa-c5b463706ebd', NULL, 0, 0, NULL, 1, 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Security].[AspNetUsers] WHERE Id = '3aaf42cc-84c4-4853-8903-0e4f8100795f'");
        }
    }
}
