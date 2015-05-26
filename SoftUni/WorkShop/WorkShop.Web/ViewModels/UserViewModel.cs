using System.Collections.Generic;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Ajax.Utilities;
using WorkShop.Models;

namespace WorkShop.Web.ViewModels
{
    public class UserViewModel
    {
        public static Expression<Func<User, UserViewModel>> ViewModel
        {
            get
            {
                return x => new UserViewModel
                {
                    AvatarUrl = x.AvatarUrl,
                    Username = x.UserName,
                    ContactInfo = x.ContactInfo,
                    Email = x.Email,
                    FullName = x.FullName,
                    Summary = x.Summary,
                    Id = x.Id,
                    Certifications = x.Certifications.AsQueryable().Select(CertificationViewModel.ViewModel),
                    Skills = x.Skills.AsQueryable().Select(SkillViewModel.ViewModel)
                };
            }
        }

        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string AvatarUrl { get; set; }

        public string Summary { get; set; }

        public ContactInfo ContactInfo { get; set; }

        public IEnumerable<CertificationViewModel> Certifications { get; set; }

        public IEnumerable<SkillViewModel> Skills { get; set; }
    }
}