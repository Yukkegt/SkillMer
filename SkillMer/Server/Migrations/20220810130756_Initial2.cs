using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillMer.Server.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_m_job_m_user_MUserId",
                table: "m_job");

            migrationBuilder.DropForeignKey(
                name: "FK_m_skill_m_user_MUserId",
                table: "m_skill");

            migrationBuilder.DropForeignKey(
                name: "FK_t_usersJob_m_job_JobId1",
                table: "t_usersJob");

            migrationBuilder.DropForeignKey(
                name: "FK_t_usersJob_m_user_UserId",
                table: "t_usersJob");

            migrationBuilder.DropForeignKey(
                name: "FK_t_usersSkill_m_skill_SkillId1",
                table: "t_usersSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_t_usersSkill_m_user_UserId",
                table: "t_usersSkill");

            migrationBuilder.DropIndex(
                name: "IX_t_usersSkill_SkillId1",
                table: "t_usersSkill");

            migrationBuilder.DropIndex(
                name: "IX_t_usersJob_JobId1",
                table: "t_usersJob");

            migrationBuilder.DropIndex(
                name: "IX_m_skill_MUserId",
                table: "m_skill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_job",
                table: "m_job");

            migrationBuilder.DropIndex(
                name: "IX_m_job_MUserId",
                table: "m_job");

            migrationBuilder.DropColumn(
                name: "SkillId1",
                table: "t_usersSkill");

            migrationBuilder.DropColumn(
                name: "JobId1",
                table: "t_usersJob");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "m_user",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "MUserId",
                table: "m_skill",
                newName: "TUsersSkillUserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "m_skill",
                newName: "SkillId");

            migrationBuilder.RenameColumn(
                name: "MUserId",
                table: "m_job",
                newName: "TUsersJobUserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "m_job",
                newName: "Category");

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
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TUsersSkillSkillId",
                table: "m_skill",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobId",
                table: "m_job",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MUserUserId",
                table: "m_job",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TUsersJobJobId",
                table: "m_job",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_job",
                table: "m_job",
                column: "JobId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_job",
                table: "m_job");

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
                name: "JobId",
                table: "m_job");

            migrationBuilder.DropColumn(
                name: "MUserUserId",
                table: "m_job");

            migrationBuilder.DropColumn(
                name: "TUsersJobJobId",
                table: "m_job");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "m_user",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TUsersSkillUserId",
                table: "m_skill",
                newName: "MUserId");

            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "m_skill",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TUsersJobUserId",
                table: "m_job",
                newName: "MUserId");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "m_job",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "SkillId1",
                table: "t_usersSkill",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobId1",
                table: "t_usersJob",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_job",
                table: "m_job",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_t_usersSkill_SkillId1",
                table: "t_usersSkill",
                column: "SkillId1");

            migrationBuilder.CreateIndex(
                name: "IX_t_usersJob_JobId1",
                table: "t_usersJob",
                column: "JobId1");

            migrationBuilder.CreateIndex(
                name: "IX_m_skill_MUserId",
                table: "m_skill",
                column: "MUserId");

            migrationBuilder.CreateIndex(
                name: "IX_m_job_MUserId",
                table: "m_job",
                column: "MUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_m_job_m_user_MUserId",
                table: "m_job",
                column: "MUserId",
                principalTable: "m_user",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_m_skill_m_user_MUserId",
                table: "m_skill",
                column: "MUserId",
                principalTable: "m_user",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersJob_m_job_JobId1",
                table: "t_usersJob",
                column: "JobId1",
                principalTable: "m_job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersJob_m_user_UserId",
                table: "t_usersJob",
                column: "UserId",
                principalTable: "m_user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersSkill_m_skill_SkillId1",
                table: "t_usersSkill",
                column: "SkillId1",
                principalTable: "m_skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersSkill_m_user_UserId",
                table: "t_usersSkill",
                column: "UserId",
                principalTable: "m_user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
