using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrouwInventaris.Models
{
    public class User:UserProfile
    {
        public Brouwerij Brouwerij { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }

    }
}