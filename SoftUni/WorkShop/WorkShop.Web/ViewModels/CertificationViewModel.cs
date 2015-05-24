using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkShop.Web.ViewModels
{
    public class CertificationViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LicenseNumber { get; set; }

        public string Url { get; set; }

        public DateTime TakenDate { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
