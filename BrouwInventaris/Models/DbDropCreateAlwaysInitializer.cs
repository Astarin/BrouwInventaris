using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrouwInventaris.Models
{
    public class DbDropCreateAlwaysInitializer : DropCreateDatabaseAlways<DbInventarisContext>
    {
        protected override void Seed(DbInventarisContext context)
        {
            // creation startupobjects
            Brouwerij rockaBeery = new Brouwerij { Naam = "Rock a Beery" };
            Brouwerij duvel = new Brouwerij { Naam = "Duvel" };
            Artikel thermometer = new Artikel { Naam = "Thermometer", Omschrijving = "dient om de temperatuur te meten." };
            Hop saaz = new Hop { Naam = "Saaz", Alfa = 5.1m, Omschrijving = "Courant gebruikte aromahop." };
            Mout pilsmout = new Mout { Ebc = 5, MaximumStorting = 100, Naam="Pilsmout", Omschrijving="Meest gebruikte mout in verschillende bierstijlen." };
            Gist gist = new Gist { Verpakking = Verpakking.Smackpack, Naam= "Whyeast", Omschrijving ="Westmalle"};
            Gist gist2 = new Gist { Verpakking = Verpakking.Zakje, Naam = "T-58", Omschrijving = "korrelgist alle biertype" };
            Overige overige1 = new Overige { Naam = "Kristalsuiker", Omschrijving = "ook voor in de koffie." };
            Overige overige2 = new Overige{Naam = "Koriander", Omschrijving="Ook lekker in nen curry"};


            User bernd = new User { UserName = "Astarin", Brouwerij = rockaBeery, Email = "ikkezelf@msn.com", FirstName = "Bernd", LastName = "Vertommen" };
            User jimmy = new User { UserName = "Dzjimmie", Brouwerij = rockaBeery, Email = "dendjimmy@msn.com", FirstName = "Jimmy", LastName = "Henderickx" };
            User kobe = new User { UserName = "minister1", Brouwerij = rockaBeery, Email = "denKobe@msn.com", FirstName = "Kobe", LastName = "Vercauteren" };
            Aankoop aankoop1 = new Aankoop { Aankoopdatum = new DateTime(2015, 02, 6), Artikel = saaz, Hoeveelheid = 2, Prijs = 8.05m, User = bernd };
            Aankoop aankoop2 = new Aankoop { Aankoopdatum = new DateTime(2015, 01, 10), Artikel = pilsmout, Hoeveelheid = 1, Prijs = 12.95m, User = bernd };
            Aankoop aankoop3 = new Aankoop { Aankoopdatum = new DateTime(2015, 01, 15), Artikel = thermometer, Hoeveelheid = 1, Prijs = 10m, User = kobe };
            Aankoop aankoop4 = new Aankoop { Aankoopdatum = new DateTime(2014, 01, 15), Artikel = saaz, Hoeveelheid = 1, Prijs = 3.05m, User = kobe };
            Aankoop aankoop5 = new Aankoop { Aankoopdatum = new DateTime(2014, 08, 13), Artikel = thermometer, Hoeveelheid = 1, Prijs = 10m, User = jimmy };
            Aankoop aankoop6 = new Aankoop { Aankoopdatum = new DateTime(2015, 01, 03), Artikel = pilsmout, Hoeveelheid = 2, Prijs = 22.6m, User = jimmy };

            // adding objects to dbSet
            context.Brouwerijen.Add(rockaBeery);
            context.Brouwerijen.Add(duvel);
            context.Artikels.Add(thermometer);
            context.Artikels.Add(saaz);
            context.Artikels.Add(pilsmout);
            context.Artikels.Add(gist);
            context.Artikels.Add(gist2);
            context.Artikels.Add(overige1);
            context.Artikels.Add(overige2);
            context.Users.Add(bernd);
            context.Users.Add(kobe);
            context.Users.Add(jimmy);
            context.Aankopen.Add(aankoop1);
            context.Aankopen.Add(aankoop2);
            context.Aankopen.Add(aankoop3);
            context.Aankopen.Add(aankoop4);
            context.Aankopen.Add(aankoop5);
            context.Aankopen.Add(aankoop6);

            context.SaveChanges(); // saving dbSet(s) to Database
        }
        
    }
}
