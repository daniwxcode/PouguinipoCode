using LompogaLibrary.Historisable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LompogaLibrary.Administation
{
    public class Agent: Horodatage
    {
        [Key]
        [ForeignKey("ID")]
        [Display(AutoGenerateField =false, Name ="La Personne",Description ="La Personne concernée", Prompt ="Selectionner la personne Concernée", Order =1)]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Veuillez Renseigner la personne")]
        public int ID { get; set; }
        public string Poste { get; set; }

        public virtual Personne Personne { get; set; }
    }
}
