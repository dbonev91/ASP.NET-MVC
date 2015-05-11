using System.ComponentModel.DataAnnotations;
namespace Twitter.Models
{
    public class UserPublicProfile
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
    }
}