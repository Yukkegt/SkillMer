using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillMer.Server.Migrations
{
    public partial class unko : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_usersJob_m_user_user_id",
                table: "t_usersJob");

            migrationBuilder.DropForeignKey(
                name: "FK_t_usersSkill_m_user_user_id",
                table: "t_usersSkill");

            migrationBuilder.RenameColumn(
                name: "skill_id",
                table: "t_usersSkill",
                newName: "SkillId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "t_usersSkill",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "job_id",
                table: "t_usersJob",
                newName: "JobId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "t_usersJob",
                newName: "UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "m_user",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DeleteFlg",
                table: "m_user",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "m_user",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "m_skill",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DeleteFlg",
                table: "m_skill",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "m_skill",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "m_job",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DeleteFlg",
                table: "m_job",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "m_job",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersJob_m_user_UserId",
                table: "t_usersJob",
                column: "UserId",
                principalTable: "m_user",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_usersJob_m_user_UserId",
                table: "t_usersJob");

            migrationBuilder.DropForeignKey(
                name: "FK_t_usersSkill_m_user_UserId",
                table: "t_usersSkill");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "m_user");

            migrationBuilder.DropColumn(
                name: "DeleteFlg",
                table: "m_user");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "m_user");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "m_skill");

            migrationBuilder.DropColumn(
                name: "DeleteFlg",
                table: "m_skill");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "m_skill");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "m_job");

            migrationBuilder.DropColumn(
                name: "DeleteFlg",
                table: "m_job");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "m_job");

            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "t_usersSkill",
                newName: "skill_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "t_usersSkill",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "t_usersJob",
                newName: "job_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "t_usersJob",
                newName: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersJob_m_user_user_id",
                table: "t_usersJob",
                column: "user_id",
                principalTable: "m_user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_usersSkill_m_user_user_id",
                table: "t_usersSkill",
                column: "user_id",
                principalTable: "m_user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
