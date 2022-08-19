using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillMer.Server.Migrations
{
    public partial class UpdateRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_m_job_m_user_MUserUserId",
                table: "m_job");

            migrationBuilder.DropForeignKey(
                name: "FK_m_job_t_usersJob_TUsersJobUserId_TUsersJobJobId",
                table: "m_job");

            migrationBuilder.DropForeignKey(
                name: "FK_m_skill_m_user_MUserUserId",
                table: "m_skill");

            migrationBuilder.DropForeignKey(
                name: "FK_m_skill_t_usersSkill_TUsersSkillUserId_TUsersSkillSkillId",
                table: "m_skill");

            migrationBuilder.DropForeignKey(
                name: "FK_m_user_t_usersJob_TUsersJobUserId_TUsersJobJobId",
                table: "m_user");

            migrationBuilder.DropForeignKey(
                name: "FK_m_user_t_usersSkill_TUsersSkillUserId_TUsersSkillSkillId",
                table: "m_user");

            migrationBuilder.DropIndex(
                name: "IX_m_user_TUsersJobUserId_TUsersJobJobId",
                table: "m_user");

            migrationBuilder.DropIndex(
                name: "IX_m_user_TUsersSkillUserId_TUsersSkillSkillId",
                table: "m_user");

            migrationBuilder.DropIndex(
                name: "IX_m_skill_MUserUserId",
                table: "m_skill");

            migrationBuilder.DropIndex(
                name: "IX_m_skill_TUsersSkillUserId_TUsersSkillSkillId",
                table: "m_skill");

            migrationBuilder.DropIndex(
                name: "IX_m_job_MUserUserId",
                table: "m_job");

            migrationBuilder.DropIndex(
                name: "IX_m_job_TUsersJobUserId_TUsersJobJobId",
                table: "m_job");

            migrationBuilder.DropColumn(
                name: "TUsersJobJobId",
                table: "m_user");

            migrationBuilder.DropColumn(
                name: "TUsersJobUserId",
                table: "m_user");

            migrationBuilder.DropColumn(
                name: "TUsersSkillSkillId",
                table: "m_user");

            migrationBuilder.DropColumn(
                name: "TUsersSkillUserId",
                table: "m_user");

            migrationBuilder.DropColumn(
                name: "MUserUserId",
                table: "m_skill");

            migrationBuilder.DropColumn(
                name: "TUsersSkillSkillId",
                table: "m_skill");

            migrationBuilder.DropColumn(
                name: "TUsersSkillUserId",
                table: "m_skill");

            migrationBuilder.DropColumn(
                name: "MUserUserId",
                table: "m_job");

            migrationBuilder.DropColumn(
                name: "TUsersJobJobId",
                table: "m_job");

            migrationBuilder.DropColumn(
                name: "TUsersJobUserId",
                table: "m_job");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "t_usersSkill",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "t_usersJob",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_t_usersSkill_SkillId",
                table: "t_usersSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_t_usersJob_JobId",
                table: "t_usersJob",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersJob_m_job_JobId",
                table: "t_usersJob",
                column: "JobId",
                principalTable: "m_job",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersJob_m_user_UserId",
                table: "t_usersJob",
                column: "UserId",
                principalTable: "m_user",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersSkill_m_skill_SkillId",
                table: "t_usersSkill",
                column: "SkillId",
                principalTable: "m_skill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersSkill_m_user_UserId",
                table: "t_usersSkill",
                column: "UserId",
                principalTable: "m_user",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_usersJob_m_job_JobId",
                table: "t_usersJob");

            migrationBuilder.DropForeignKey(
                name: "FK_t_usersJob_m_user_UserId",
                table: "t_usersJob");

            migrationBuilder.DropForeignKey(
                name: "FK_t_usersSkill_m_skill_SkillId",
                table: "t_usersSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_t_usersSkill_m_user_UserId",
                table: "t_usersSkill");

            migrationBuilder.DropIndex(
                name: "IX_t_usersSkill_SkillId",
                table: "t_usersSkill");

            migrationBuilder.DropIndex(
                name: "IX_t_usersJob_JobId",
                table: "t_usersJob");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "t_usersSkill",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "t_usersJob",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.AddColumn<int>(
                name: "TUsersJobJobId",
                table: "m_user",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TUsersJobUserId",
                table: "m_user",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TUsersSkillSkillId",
                table: "m_user",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TUsersSkillUserId",
                table: "m_user",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MUserUserId",
                table: "m_skill",
                type: "varchar(15)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TUsersSkillSkillId",
                table: "m_skill",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TUsersSkillUserId",
                table: "m_skill",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MUserUserId",
                table: "m_job",
                type: "varchar(15)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TUsersJobJobId",
                table: "m_job",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TUsersJobUserId",
                table: "m_job",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_m_user_TUsersJobUserId_TUsersJobJobId",
                table: "m_user",
                columns: new[] { "TUsersJobUserId", "TUsersJobJobId" });

            migrationBuilder.CreateIndex(
                name: "IX_m_user_TUsersSkillUserId_TUsersSkillSkillId",
                table: "m_user",
                columns: new[] { "TUsersSkillUserId", "TUsersSkillSkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_m_skill_MUserUserId",
                table: "m_skill",
                column: "MUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_m_skill_TUsersSkillUserId_TUsersSkillSkillId",
                table: "m_skill",
                columns: new[] { "TUsersSkillUserId", "TUsersSkillSkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_m_job_MUserUserId",
                table: "m_job",
                column: "MUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_m_job_TUsersJobUserId_TUsersJobJobId",
                table: "m_job",
                columns: new[] { "TUsersJobUserId", "TUsersJobJobId" });

            migrationBuilder.AddForeignKey(
                name: "FK_m_job_m_user_MUserUserId",
                table: "m_job",
                column: "MUserUserId",
                principalTable: "m_user",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_m_job_t_usersJob_TUsersJobUserId_TUsersJobJobId",
                table: "m_job",
                columns: new[] { "TUsersJobUserId", "TUsersJobJobId" },
                principalTable: "t_usersJob",
                principalColumns: new[] { "UserId", "JobId" });

            migrationBuilder.AddForeignKey(
                name: "FK_m_skill_m_user_MUserUserId",
                table: "m_skill",
                column: "MUserUserId",
                principalTable: "m_user",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_m_skill_t_usersSkill_TUsersSkillUserId_TUsersSkillSkillId",
                table: "m_skill",
                columns: new[] { "TUsersSkillUserId", "TUsersSkillSkillId" },
                principalTable: "t_usersSkill",
                principalColumns: new[] { "UserId", "SkillId" });

            migrationBuilder.AddForeignKey(
                name: "FK_m_user_t_usersJob_TUsersJobUserId_TUsersJobJobId",
                table: "m_user",
                columns: new[] { "TUsersJobUserId", "TUsersJobJobId" },
                principalTable: "t_usersJob",
                principalColumns: new[] { "UserId", "JobId" });

            migrationBuilder.AddForeignKey(
                name: "FK_m_user_t_usersSkill_TUsersSkillUserId_TUsersSkillSkillId",
                table: "m_user",
                columns: new[] { "TUsersSkillUserId", "TUsersSkillSkillId" },
                principalTable: "t_usersSkill",
                principalColumns: new[] { "UserId", "SkillId" });
        }
    }
}
