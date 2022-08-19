﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkillMa.EntityFramework;

#nullable disable

namespace SkillMer.Server.Migrations
{
    [DbContext(typeof(SkillMerDbContext))]
    [Migration("20220810132922_AddOrderAndType")]
    partial class AddOrderAndType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("SkillMer.Shared.Entities.MJob", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(98);

                    b.Property<bool>("DeleteFlg")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(97);

                    b.Property<string>("MUserUserId")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(3);

                    b.Property<int?>("TUsersJobJobId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TUsersJobUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(99);

                    b.HasKey("JobId");

                    b.HasIndex("MUserUserId");

                    b.HasIndex("TUsersJobUserId", "TUsersJobJobId");

                    b.ToTable("m_job", (string)null);
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.MSkill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(98);

                    b.Property<bool>("DeleteFlg")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(97);

                    b.Property<string>("MUserUserId")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(3);

                    b.Property<int?>("TUsersSkillSkillId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TUsersSkillUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(99);

                    b.HasKey("SkillId");

                    b.HasIndex("MUserUserId");

                    b.HasIndex("TUsersSkillUserId", "TUsersSkillSkillId");

                    b.ToTable("m_skill", (string)null);
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.MUser", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(15)")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(98);

                    b.Property<bool>("DeleteFlg")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(97);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnOrder(2);

                    b.Property<int?>("TUsersJobJobId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TUsersJobUserId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TUsersSkillSkillId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TUsersSkillUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(99);

                    b.HasKey("UserId");

                    b.HasIndex("TUsersJobUserId", "TUsersJobJobId");

                    b.HasIndex("TUsersSkillUserId", "TUsersSkillSkillId");

                    b.ToTable("m_user", (string)null);
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.TUsersJob", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(1);

                    b.Property<int>("JobId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(98);

                    b.Property<bool>("DeleteFlg")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(97);

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(99);

                    b.HasKey("UserId", "JobId");

                    b.ToTable("t_usersJob", (string)null);
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.TUsersSkill", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(1);

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(98);

                    b.Property<bool>("DeleteFlg")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(97);

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(99);

                    b.HasKey("UserId", "SkillId");

                    b.ToTable("t_usersSkill", (string)null);
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.MJob", b =>
                {
                    b.HasOne("SkillMer.Shared.Entities.MUser", null)
                        .WithMany("Jobs")
                        .HasForeignKey("MUserUserId");

                    b.HasOne("SkillMer.Shared.Entities.TUsersJob", null)
                        .WithMany("Jobs")
                        .HasForeignKey("TUsersJobUserId", "TUsersJobJobId");
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.MSkill", b =>
                {
                    b.HasOne("SkillMer.Shared.Entities.MUser", null)
                        .WithMany("Skills")
                        .HasForeignKey("MUserUserId");

                    b.HasOne("SkillMer.Shared.Entities.TUsersSkill", null)
                        .WithMany("Skills")
                        .HasForeignKey("TUsersSkillUserId", "TUsersSkillSkillId");
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.MUser", b =>
                {
                    b.HasOne("SkillMer.Shared.Entities.TUsersJob", null)
                        .WithMany("Users")
                        .HasForeignKey("TUsersJobUserId", "TUsersJobJobId");

                    b.HasOne("SkillMer.Shared.Entities.TUsersSkill", null)
                        .WithMany("Users")
                        .HasForeignKey("TUsersSkillUserId", "TUsersSkillSkillId");
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.MUser", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.TUsersJob", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.TUsersSkill", b =>
                {
                    b.Navigation("Skills");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
