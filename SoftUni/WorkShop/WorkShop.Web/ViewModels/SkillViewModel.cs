using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WorkShop.Models;

namespace WorkShop.Web.ViewModels
{
    public class SkillViewModel
    {
        public static Expression<Func<UserSkill, SkillViewModel>> ViewModel
        {
            get
            {
                return x => new SkillViewModel
                {
                    Id = x.Id,
                    Name = x.Skill.Name,
                    Endorsments = x.Endorsments.Count,
                    Endorcers = x.Endorsments.Select(e => e.User.UserName)
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Endorsments { get; set; }

        public IEnumerable<string> Endorcers { get; set; }
    }
}
