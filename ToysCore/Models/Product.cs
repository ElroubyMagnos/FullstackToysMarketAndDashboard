using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysCore.Models
{
    public class Product
    {
        public int ID { get; set; }
        public byte[] Image { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public double BuyPrice { get; set; }
        public double Price { get; set; }
        public double DiscountNow { get; set; }
        public int CategoryID { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        public Category LinkedCategory { get; set; }
        public ICollection<PaidProduct> LinkedProductsSon { get; set; }
    }
}
