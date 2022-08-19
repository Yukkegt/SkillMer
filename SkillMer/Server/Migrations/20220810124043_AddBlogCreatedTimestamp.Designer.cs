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
    [Migration("20220810124043_AddBlogCreatedTimestamp")]
    partial class AddBlogCreatedTimestamp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("SkillMer.Shared.Entities.MJob", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteFlg")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MUserId");

                    b.ToTable("m_job", (string)null);
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.MSkill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteFlg")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MUserId");

                    b.ToTable("m_skill", (string)null);
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.MUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteFlg")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("m_user", (string)null);
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.TUsersJob", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("JobId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteFlg")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobId1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "JobId");

                    b.HasIndex("JobId1");

                    b.ToTable("t_usersJob", (string)null);
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.TUsersSkill", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteFlg")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SkillId1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "SkillId");

                    b.HasIndex("SkillId1");

                    b.ToTable("t_usersSkill", (string)null);
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.MJob", b =>
                {
                    b.HasOne("SkillMer.Shared.Entities.MUser", null)
                        .WithMany("Job")
                        .HasForeignKey("MUserId");
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.MSkill", b =>
                {
                    b.HasOne("SkillMer.Shared.Entities.MUser", null)
                        .WithMany("Skill")
                        .HasForeignKey("MUserId");
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.TUsersJob", b =>
                {
                    b.HasOne("SkillMer.Shared.Entities.MJob", "Job")
                        .WithMany()
                        .HasForeignKey("JobId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkillMer.Shared.Entities.MUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.TUsersSkill", b =>
                {
                    b.HasOne("SkillMer.Shared.Entities.MSkill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkillMer.Shared.Entities.MUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SkillMer.Shared.Entities.MUser", b =>
                {
                    b.Navigation("Job");

                    b.Navigation("Skill");
                });
#pragma warning restore 612, 618
        }
    }
}
