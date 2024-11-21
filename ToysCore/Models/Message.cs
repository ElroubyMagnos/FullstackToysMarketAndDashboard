using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysCore.Models
{
    public class Message
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string SenderIP { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }
        public bool SendByPanel { get; set; }
        public bool SeenByCustomer { get; set; }
        public bool SeenByPanelManager { get; set; }
    }
}
