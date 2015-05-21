namespace WorkShop.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using WorkShop.Models;
    using WorkShop.Data.Migrations;

    public class WorkShopDbContext : IdentityDbContext<User>, IWorkShopDbContext
    {
        public WorkShopDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WorkShopDbContext, Configuration>());
        }

        public static WorkShopDbContext Create()
        {
            return new WorkShopDbContext();
        }

        public IDbSet<Certification> Certifications { get; set; }

        public IDbSet<Discussion> Discussions { get; set; }

        public IDbSet<Experience> Experiences { get; set; }

        public IDbSet<Group> Groups { get; set; }

        public IDbSet<UserLanguage> Languages { get; set; }

        public IDbSet<Project> Projects { get; set; }

        public IDbSet<Skill> Skills { get; set; }

        public IDbSet<Endorsment> Endorsments { get; set; }

        public IDbSet<AdministrationLog> AdministrationLogs { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endorsment>()
                .HasRequired(x => x.UserSkill)
                .WithMany(x => x.Endorsments)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .HasRequired(x => x.Owner)
                .WithOptional()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Experience>()
                .HasRequired(x => x.User)
                .WithMany(x => x.Experiences)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
		}
    }
}
