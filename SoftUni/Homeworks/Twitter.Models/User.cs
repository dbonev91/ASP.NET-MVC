namespace Twitter.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        private ICollection<User> followers;

        private ICollection<User> following;

        private ICollection<Tweet> favouriteTweets;

        public User()
        {
            this.Followers = new HashSet<User>();
            this.Following = new HashSet<User>();
            this.FavouriteTweets = new HashSet<Tweet>();
        }

        [Key]
        public int Id { get; set; } 

        [Required]
        [MaxLength(45)]
        [MinLength(3)]
        public string Username { get; set; }

        [Required]
        [MaxLength(45)]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [MinLength(9)]
        public string Email { get; set; }

        public int UserPublicProfileId { get; set; }

        public virtual ICollection<User> Followers
        {
            get
            {
                return this.followers;
            }
            set
            {
                this.followers = value;
            }
        }

        public virtual ICollection<User> Following
        {
            get
            {
                return this.following;
            }
            set
            {
                this.following = value;
            }
        }

        public virtual ICollection<Tweet> FavouriteTweets
        {
            get
            {
                return this.favouriteTweets;
            }
            set
            {
                this.favouriteTweets = value;
            }
        }
    }
}
