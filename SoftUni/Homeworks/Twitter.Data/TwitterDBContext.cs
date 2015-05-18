namespace Twitter.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using Twitter.Data.Migrations;
    using Twitter.Models;

    public class TwitterDBContext : IdentityDbContext<User>
    {
        public TwitterDBContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TwitterDBContext Create()
        {
            return new TwitterDBContext();
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Tweet> Tweets { get; set; }

        public DbSet<UserPublicProfile> UserPublicProfiles { get; set; }
    }
}
