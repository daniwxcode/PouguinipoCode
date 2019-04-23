using LompogaLibrary.Administation;
using System;
using System.Collections.Generic;
using System.Text;

namespace LompogaLibrary.Historisable
{
    public class Horodatage
    {
        public DateTime DateCréation { get; set; } = DateTime.Now;
        public int IdCreateur { get; set; }
        public Utilisateur Createur { get; set; }

        public DateTime DerniereModification { get; set; }
        public int? idModificateur { get; set; }
        public Utilisateur? modificateur { get; set; }



    }
}
