using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Model
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime NotificationDate { get; set; }

        public NotificationType NotificationType { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
