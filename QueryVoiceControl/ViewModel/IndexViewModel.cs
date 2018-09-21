using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QueryVoiceControl.Models;

namespace QueryVoiceControl.ViewModel
{
    public class IndexViewModel
    {
        public ICollection<Studente> Studenti { get; set; }
        public string[,] Tabella { get; set; }
        public string Speech { get; set; }
    }
}
