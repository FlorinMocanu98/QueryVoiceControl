using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueryVoiceControl.Models
{
    public class Studente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudenteID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public string Classe { get; set; }
        public string Scuola { get; set; }
    }
}
