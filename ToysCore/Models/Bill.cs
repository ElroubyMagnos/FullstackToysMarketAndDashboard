using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysCore.Models
{
    public class Bill
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string CustomerPhone { get; set; }
        [MaxLength(50)]
        public string CustomerAddress { get; set; }
        public bool IsDelivery { get; set; }
        public int BillNumber { get; set; }
        public string IPAddress { get; set; }
        public bool IsOpen { get; set; }
        public ICollection<PaidProduct> LinkedPaidProducts { get; set; }
    }
}
