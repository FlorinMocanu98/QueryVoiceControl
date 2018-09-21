using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QueryVoiceControl.Models {
    public class Professore {


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfessoreID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public string Materia { get; set; }
        public string Scuola { get; set; }
    }
}
