using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysCore.Models
{
    public class PaidProduct
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public int BillID { get; set; }
        public int ParentProductID { get; set; }
        public Bill LinkedBill { get; set; }
        public Product LinkedProduct { get; set; }
    }
}
