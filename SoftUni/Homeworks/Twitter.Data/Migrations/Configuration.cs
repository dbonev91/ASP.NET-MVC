namespace Twitter.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Twitter.Models;

    public sealed class Configuration : DbMigrationsConfiguration<TwitterDBContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TwitterDBContext context)
        {
            var userDbonev = new User
            {
                Username = "dbonev",
                Password = "aaaaaa",
                Email = "dbonev91@gmmail.com"
            };

            var userKibork = new User
            {
                Username = "Kibork",
                Password = "123456",
                Email = "Kibork4o@gmail.com"
            };

            var userSomeUser = new User
            {
                Username = "SomeUser",
                Password = "654321",
                Email = "mailMe@abv.bg"
            };

            userKibork.Following = new List<User>()
            {
                userDbonev,
                userSomeUser
            };

            userSomeUser.Following = new List<User>()
            {
                userDbonev
            };

            var tweetSomeTweet = new Tweet
            {
                URL = "http://dbonev.com"
            };

            userDbonev.FavouriteTweets = new List<Tweet>()
            {
                tweetSomeTweet
            };
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
