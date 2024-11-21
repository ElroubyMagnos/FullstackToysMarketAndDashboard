using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysCore.Models
{
    public class EmailMsg
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(1000)]
        public string Message { get; set; }
    }
}
