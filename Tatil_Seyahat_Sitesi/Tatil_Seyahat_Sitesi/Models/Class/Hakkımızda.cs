using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Class
{
    public class Hakkımızda
    {
        [Key]
        public int ID { get; set; }
        public string Fotourl { get; set; }
        public string Aciklama { get; set; }
    }
}