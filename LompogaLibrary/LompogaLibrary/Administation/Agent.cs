using LompogaLibrary.Historisable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LompogaLibrary.Administation
{
    [Table("Agent", Schema = "Admin")]
    public class Agent: Personne
    {
        
        [Display(AutoGenerateField = false, Name = "Poste", Description = "Le Poste occupé", Prompt = "Renseigner Le Poste occupé", Order = 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Veuillez Renseigner la personne")]
        protected string Poste { get; set; }

        protected virtual Personne Personne { get; set; }
    }
}
