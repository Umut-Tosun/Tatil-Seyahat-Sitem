using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Class
{
    public class iletisim
    {
        [Key]
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail{ get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }
}