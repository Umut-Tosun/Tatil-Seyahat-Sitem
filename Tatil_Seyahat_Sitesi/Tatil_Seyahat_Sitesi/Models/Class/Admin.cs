using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Class
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string Kullanici_Adi { get; set; }
        public string Sifre { get; set; }
    }
}