using Microsoft.EntityFrameworkCore;
using SkillMer.Shared.Entities;

namespace SkillMa.EntityFramework
{
    public class SkillMerDbContext : DbContext
    {
        public SkillMerDbContext(DbContextOptions<SkillMerDbContext> options)
            : base(options)
        {
        }

        public DbSet<MUser> Users { get; set; }
        public DbSet<MSkill> Skills { get; set; }
        public DbSet<MJob> Jobs { get; set; }
        public DbSet<TUsersSkill> UsersSkill { get; set; }
        public DbSet<TUsersJob> UsersJob { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 複合キーの場合、以下のように指定してやる。
            // ない場合「Entity type 'Item' has composite primary key defined with data annotations. To set composite primary key, use fluent API.」と表示される
            modelBuilder.Entity<MUser>().ToTable("m_user");

            modelBuilder.Entity<MSkill>().ToTable("m_skill");

            modelBuilder.Entity<MJob>().ToTable("m_job");

            modelBuilder.Entity<TUsersSkill>().ToTable("t_usersSkill").HasKey(us => new { us.UserId, us.SkillId });

            modelBuilder.Entity<TUsersJob>().ToTable("t_usersJob").HasKey(uj => new { uj.UserId, uj.JobId });

            //modelBuilder.Entity<CommonEntity>()
            //.Property(m => m.CreateAt)
            //.HasDefaultValueSql("GETDATE()");

            //modelBuilder.Entity<CommonEntity>()
            //.Property(m => m.UpdateAt)
            //.HasDefaultValueSql("GETDATE()");

        }
    }
}
