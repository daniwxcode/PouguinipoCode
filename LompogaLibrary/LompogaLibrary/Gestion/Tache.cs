using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LompogaLibrary.Gestion
{
    class Tache
    {
        [Key]
        public int IdTache { get; set; }
        public string LibelleTAche { get; set; }

        [ForeignKey("IdTache")]
        public int? IdTachePrec { get; set; }
        public virtual Tache? TachePrécente { get; set; }

        [ForeignKey("IdTache")]
        public int? IdTacheSuiv { get; set; }

        public virtual Tache? TacheSuivante { get; set; }
    }
}
