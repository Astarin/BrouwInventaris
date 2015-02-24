using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;


namespace BrouwInventaris.Models
{
  
    public abstract class Artikel
    {
        public int Id { get; set; }
        public string Naam{ get; set; }
        public string Omschrijving { get; set; }

        public abstract string ConvertAmountToHumanReadable(int Amount);

    }
}