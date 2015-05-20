using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Model
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        private ICollection<ApplicationUser> followersList;

        private ICollection<ApplicationUser> followingList;

        private ICollection<Tweet> ownTweetsList;

        private ICollection<Tweet> favouriteTweetsList;

        public ApplicationUser()
        {
            this.OwnTweetsList = new HashSet<Tweet>();
            this.FavouriteTweetsList = new HashSet<Tweet>();
            this.FollowersList = new HashSet<ApplicationUser>();
            this.FollowingList = new HashSet<ApplicationUser>();
        }

        public virtual ICollection<ApplicationUser> FollowersList
        {
            get
            {
                return this.followersList;
            }
            set
            {
                this.followersList = value;
            }
        }

        public virtual ICollection<ApplicationUser> FollowingList
        {
            get
            {
                return this.followingList;
            }
            set
            {
                this.followingList = value;
            }
        }

        public virtual ICollection<Tweet> OwnTweetsList
        {
            get
            {
                return this.ownTweetsList;
            }
            set
            {
                this.ownTweetsList = value;
            }
        }

        public virtual ICollection<Tweet> FavouriteTweetsList
        {
            get
            {
                return this.favouriteTweetsList;
            }
            set
            {
                this.favouriteTweetsList = value;
            }
        }

        public int ProfileId { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
