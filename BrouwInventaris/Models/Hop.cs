using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrouwInventaris.Models
{
    public class Hop:Artikel
    {
        
        public decimal Alfa { get; set; }

        public override string ConvertAmountToHumanReadable(int Amount)
        {
            //todo
            return string.Format("{0} g", Amount);
        }
    }
}