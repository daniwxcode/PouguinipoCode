using LompogaLibrary.Historisable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LompogaLibrary.Administation
{
    [Table("Droits",Schema ="Admin")]
    public class Droits : Horodatage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDdroit { get; set; }

        [Display(AutoGenerateField = false, Name = "Libelle Droit", Description = "l'intitulé du droit", Prompt = "Renseigner Le droit", Order = 1)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Veuillez Renseigner la personne")]
        public string LibelleDroit { get; set; }
        [Display(Name = "Activer l'habilitation", Prompt = "Activer ou désactiver ce droit", Description = @"Activation du droit")]
        public bool EtatDroit { get; set; } = false;

        public ICollection<Habilitations> habilitations { get; set; }
    }
}
