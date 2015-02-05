using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrouwInventaris.Models
{
    public class User:UserProfile
    {
        public Brouwerij Brouwerij { get; set; }
    }
}