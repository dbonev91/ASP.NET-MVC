namespace Twitter.Data
{
    using System.Data.Entity;
    using Twitter.Data.Migrations;
    using Twitter.Models;

    public class TwitterDBContext : DbContext
    {
        public TwitterDBContext()
            : base ("TweeterDB")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Tweet> Tweets { get; set; }

        public DbSet<UserPublicProfile> UserPublicProfiles { get; set; }
    }
}
