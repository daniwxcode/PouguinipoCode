using LompogaLibrary.Historisable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LompogaLibrary.Administation
{
    public class Profil : Horodatage
    {
        [Key]
        public int IDProfil { get; set; }

        [Display(Name = "Libellé du Profil", Prompt = "Entrer le libellé du Profil",
            Order = 1)]
        [Required(ErrorMessage = "le libellé du profil est obligatoire", 
            AllowEmptyStrings = false)]
        public string Libelle { get; set; }

        [Display(Name = "Activer ce Profil", Description = "Activer ou désactiver ce profil",
            Prompt = " cocher pour Activer ou décocher pour désactiver ce profil")]
        public bool activer { get; set; } = false;

        [Display(Name = "Supérieur Hiérarchique", 
            Prompt = "Choisir le Supérieur Hiérarchique", 
            GroupName = "Hiérarchie")]
        [ForeignKey("IDProfil")]
        public int? ProfilSupérieurID { get; set; }

        public Profil? ProfilSuperieur { get; set; }
        public ICollection<Profil> profilsSubordonnées { get; set; }
        public virtual ICollection<Habilitations> Habilitations { get; set; }

    }
}
