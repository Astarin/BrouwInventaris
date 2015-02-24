using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BrouwInventaris.Models
{
    public class DbInventarisContext : DbContext
    {
        // Info Connect in server explorer met : (LocalDb)\V11.0
        public DbInventarisContext()  : base("BrouwInventaris")
        {
            //Database.SetInitializer<DbInventarisContext>(new DbDropCreateAlwaysInitializer()); // altijd nieuwe database volgens de initialisatie klasse.
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Brouwerij> Brouwerijen { get; set; }
        public DbSet<Aankoop> Aankopen { get; set; }
        public DbSet<Artikel> Artikels{ get; set; }
        public DbSet<Hop> Hoppen { get; set; }
        public DbSet<Mout> Mouten { get; set; }
        
    }
}
