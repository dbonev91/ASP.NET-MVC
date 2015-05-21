using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.Models
{
    public class UserSkill
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int SkillId { get; set; }

        public virtual Skill Skill { get; set; }

        public virtual ICollection<Endorsment> Endorsments { get; set; }
    }
}
