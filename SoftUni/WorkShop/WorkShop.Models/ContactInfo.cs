using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.Models
{
    [ComplexType]
    public class ContactInfo
    {
        public string Phone { get; set; }

        public string Twitter { get; set; }

        public string Website { get; set; }

        public string Facebook { get; set; }
    }
}
