using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrouwInventaris.Models
{
    public class Aankoop
    {
        public Artikel Artikel { get; set; }
        public User User { get; set; }
        public decimal Prijs { get; set; }
        public DateTime Aankoopdatum { get; set; }
        public int Hoeveelheid { get; set; }
    }
}