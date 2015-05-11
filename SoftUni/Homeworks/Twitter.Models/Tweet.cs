using System.ComponentModel.DataAnnotations;
namespace Twitter.Models
{
    public class Tweet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string URL { get; set; }
    }
}
