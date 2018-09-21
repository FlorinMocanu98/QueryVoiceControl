using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QueryVoiceControl.Data;
using QueryVoiceControl.Models;

namespace QueryVoiceControl.Data
{
    public class DbInitializer
    {
        public static void Initialize(MyDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Studenti.Any())
            {
                return;   // DB has been seeded
            }

            var studenti = new Studente[]
            {
            new Studente{Nome="Carson",Cognome="Alexander", Eta = 18, Classe="4G", Scuola = "ISII G. Marconi"},
            new Studente{Nome="Meredith",Cognome="Alonso",Eta = 17,Classe="3G", Scuola = "Colombini"},
            new Studente{Nome="Arturo",Cognome="Anand",Eta = 16, Classe="2G",Scuola = "ISII G. Marconi"},
            new Studente{Nome="Gytis",Cognome="Barzdukas",Eta = 19, Classe="5G", Scuola = "Gioia"},
            };
            foreach (Studente s in studenti)
            {
                context.Studenti.Add(s);
            }
            context.SaveChanges();

            var professori = new Professore[]
            {
            new Professore{Nome="Marco",Cognome="Zucchini", Eta = 55,  Scuola = "ISII G. Marconi"},
            new Professore{Nome="Max",Cognome="Pancini",Eta = 55, Scuola = "ISII G. Marconi"},
            new Professore{Nome="MariaLuisa",Cognome="Silva",Eta = 55, Scuola = "ISII G. Marconi"},
            new Professore{Nome="Luciana",Cognome="Badini",Eta = 55, Scuola = "ISII G. Marconi"},
            };
            foreach (Professore s in professori) {
                context.Professori.Add(s);
            }
            context.SaveChanges();

        }
    }
}

