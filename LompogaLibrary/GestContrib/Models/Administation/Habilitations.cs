using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LompogaLibrary.Historisable;

namespace LompogaLibrary.Administation
{
    public abstract class Habilitations : Horodatage
    {
        [Key, Column(Order = 1)]
        protected int IdHabilitattion{ get; set; }

        [Display(Name = "Activer l'habilitation", Prompt = "Activer ou désactiver cette habillitation", Description = @"Activation de l'Habilitation", GroupName = "Habilitation")]
        public bool EtatHabilitations { get; set; }

      

        [Key, Column(Order = 3)]
        [Display(Name = "Droit", AutoGenerateField = false, Order = 2,
           Prompt = "Sélectionner le droit concerné",
           GroupName = "Habilitation",
           Description = "Droit à attribuer")]
        [ForeignKey("IDdroit")]
        public int IdDroit { get; set; }

        public virtual Droits Droits { get; set; }
      
 
    }
}
