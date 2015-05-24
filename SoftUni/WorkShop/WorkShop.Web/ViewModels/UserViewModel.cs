using System.Collections.Generic;
using WorkShop.Models;

namespace WorkShop.Web.ViewModels
{
    public class UserViewModel
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string AvatarUrl { get; set; }

        public string Summary { get; set; }

        public ContactInfo ContactInfo { get; set; }

        public IEnumerable<CertificationViewModel> Certifications { get; set; }
    }
}