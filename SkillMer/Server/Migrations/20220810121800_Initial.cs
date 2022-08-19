using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillMer.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "m_user",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "m_job",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    MUserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_job", x => x.Id);
                    table.ForeignKey(
                        name: "FK_m_job_m_user_MUserId",
                        column: x => x.MUserId,
                        principalTable: "m_user",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "m_skill",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    SkillName = table.Column<string>(type: "TEXT", nullable: false),
                    MUserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_m_skill_m_user_MUserId",
                        column: x => x.MUserId,
                        principalTable: "m_user",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "t_usersJob",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "INTEGER", nullable: false),
                    job_id = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId1 = table.Column<string>(type: "TEXT", nullable: false),
                    JobId1 = table.Column<string>(type: "TEXT", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeleteFlg = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_usersJob", x => new { x.user_id, x.job_id });
                    table.ForeignKey(
                        name: "FK_t_usersJob_m_job_JobId1",
                        column: x => x.JobId1,
                        principalTable: "m_job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_usersJob_m_user_UserId1",
                        column: x => x.UserId1,
                        principalTable: "m_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_usersSkill",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "INTEGER", nullable: false),
                    skill_id = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId1 = table.Column<string>(type: "TEXT", nullable: false),
                    SkillId1 = table.Column<string>(type: "TEXT", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeleteFlg = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_usersSkill", x => new { x.user_id, x.skill_id });
                    table.ForeignKey(
                        name: "FK_t_usersSkill_m_skill_SkillId1",
                        column: x => x.SkillId1,
                        principalTable: "m_skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_usersSkill_m_user_UserId1",
                        column: x => x.UserId1,
                        principalTable: "m_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_m_job_MUserId",
                table: "m_job",
                column: "MUserId");

            migrationBuilder.CreateIndex(
                name: "IX_m_skill_MUserId",
                table: "m_skill",
                column: "MUserId");

            migrationBuilder.CreateIndex(
                name: "IX_t_usersJob_JobId1",
                table: "t_usersJob",
                column: "JobId1");

            migrationBuilder.CreateIndex(
                name: "IX_t_usersJob_UserId1",
                table: "t_usersJob",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_t_usersSkill_SkillId1",
                table: "t_usersSkill",
                column: "SkillId1");

            migrationBuilder.CreateIndex(
                name: "IX_t_usersSkill_UserId1",
                table: "t_usersSkill",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_usersJob");

            migrationBuilder.DropTable(
                name: "t_usersSkill");

            migrationBuilder.DropTable(
                name: "m_job");

            migrationBuilder.DropTable(
                name: "m_skill");

            migrationBuilder.DropTable(
                name: "m_user");
        }
    }
}
