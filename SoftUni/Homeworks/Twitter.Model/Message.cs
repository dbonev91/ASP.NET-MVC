using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Model
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }

        public string SenderId { get; set; }

        public virtual ApplicationUser Sender { get; set; }

        public string ReciverId { get; set; }

        public virtual ApplicationUser Reciver { get; set; }
    }
}
