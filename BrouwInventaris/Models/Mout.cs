using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrouwInventaris.Models
{
    public class Mout:Artikel
    {
        public int Ebc { get; set; }
        public int MaximumStorting { get; set; }
        // test

        public override string ConvertAmountToHumanReadable(int Amount)
        {
            return string.Format("{0} g", Amount);
        }
    }
}