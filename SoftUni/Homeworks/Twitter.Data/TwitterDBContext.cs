using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Model;

namespace Twitter.Data
{

    public class TwitterDBContext : IdentityDbContext<ApplicationUser>
    {
        public TwitterDBContext()
            : base("TwitterDB", throwIfV1Schema: false)
        {
        }

        public static TwitterDBContext Create()
        {
            return new TwitterDBContext();
        }

        // public IDbSet<User> Users { get; set; }

        public IDbSet<Tweet> Tweets { get; set; }

        public IDbSet<Profile> Profiles { get; set; }

        public IDbSet<Notification> Notifications { get; set; }

        public IDbSet<Message> Messages { get; set; }
        
        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
