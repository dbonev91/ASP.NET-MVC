using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Model
{
    public class Tweet
    {
        private ICollection<ApplicationUser> usersFavouriteList;

        private ICollection<Tweet> tweetRepliesList;

        public Tweet() {
            this.UsersFavouriteList = new HashSet<ApplicationUser>();
            this.TweetRepliesList = new HashSet<Tweet>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string URL { get; set; }

        public DateTime Date { get; set; }

        public int AuthorId { get; set; }
        
        [ForeignKey("AuthorId")]
        public virtual ApplicationUser Author { get; set; }

        public virtual ICollection<ApplicationUser> UsersFavouriteList
        {
            get
            {
                return this.usersFavouriteList;
            }
            set
            {
                this.usersFavouriteList = value;
            }
        }

        public virtual ICollection<Tweet> TweetRepliesList
        {
            get
            {
                return this.tweetRepliesList;
            }
            set
            {
                this.tweetRepliesList = value;
            }
        }
    }
}
