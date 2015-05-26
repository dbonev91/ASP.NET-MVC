using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Glimpse.Mvc.AlternateType;
using Microsoft.Ajax.Utilities;
using System.Linq.Expressions;
using WorkShop.Models;

namespace WorkShop.Web.ViewModels
{
    public class CertificationViewModel
    {
        public static Expression<Func<Certification, CertificationViewModel>> ViewModel
        {
            get
            {
                return x => new CertificationViewModel
                {
                    ExpirationDate = x.ExpirationDate,
                    Id = x.Id,
                    LicenseNumber = x.LicenseNumber,
                    Name = x.Name,
                    TakenDate = x.TakenDate,
                    Url = x.Url
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string LicenseNumber { get; set; }

        public string Url { get; set; }

        public DateTime TakenDate { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
