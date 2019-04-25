using LompogaLibrary.Historisable;
using System;
namespace LompogaLibrary.Administation
{
    public abstract class Habilitations : Horodatage
    {
        protected int IdHabilitattion{ get; set; }

        [Display(Name = "Activer l'habilitation", Prompt = "Activer ou désactiver cette habillitation", Description = @"Activation de l'Habilitation", GroupName = "Habilitation")]
        public bool EtatHabilitations { get; set; }

        [Display(Name = "Droit", AutoGenerateField = false, Order = 2, Prompt = "Selectionner le droit à Attribuer", GroupName = "Habilitation", Description = "Droit à Attribuer à un  profil")]
        public int IdDroit { get; set; }

        public virtual Droits Droit { get; set; }
    }
}
