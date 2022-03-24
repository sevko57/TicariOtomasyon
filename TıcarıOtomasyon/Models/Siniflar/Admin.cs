using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TıcarıOtomasyon.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int AdmiNID { get; set; } 
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string yetki { get; set; }
    }
}