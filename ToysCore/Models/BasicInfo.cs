using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysCore.Models
{
    public class BasicInfo
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string AddressOfUs { get; set; }
        [MaxLength(100)]
        public string fblink { get; set; }
        [MaxLength(50)]
        public string PhoneOfUs { get; set; }
    }
}
