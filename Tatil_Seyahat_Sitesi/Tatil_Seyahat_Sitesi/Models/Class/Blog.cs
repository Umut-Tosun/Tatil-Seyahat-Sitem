using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Class
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string bASLİK { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string Blogimage { get; set; }
        public ICollection<Yorumlar> Yorumlars{get;set; }
    }
}