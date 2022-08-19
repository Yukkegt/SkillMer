using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillMer.Server.Migrations
{
    public partial class UserIdUpdateToStr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_usersJob_m_user_UserId1",
                table: "t_usersJob");

            migrationBuilder.DropIndex(
                name: "IX_t_usersJob_UserId1",
                table: "t_usersJob");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "t_usersJob");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "t_usersJob",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersJob_m_user_user_id",
                table: "t_usersJob",
                column: "user_id",
                principalTable: "m_user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_usersJob_m_user_user_id",
                table: "t_usersJob");

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "t_usersJob",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "t_usersJob",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_t_usersJob_UserId1",
                table: "t_usersJob",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersJob_m_user_UserId1",
                table: "t_usersJob",
                column: "UserId1",
                principalTable: "m_user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
