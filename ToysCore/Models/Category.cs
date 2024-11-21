using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysCore.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Desc { get; set; }
        public byte[] Image { get; set; }
        public ICollection<Product> LinkedProducts { get; set; }
    }
}
