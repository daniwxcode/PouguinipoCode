using LompogaLibrary.Administation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LompogaLibrary.Historisable
{
    public class Horodatage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField =true)]
        public DateTime DateCréation { get; set; } = DateTime.UtcNow;

        [ForeignKey("PersonneID")]
        [Display(Name = "Créateur", Description = "Auteur")]
        public int IdCreateur { get; set; }
       // public virtual Utilisateur Createur { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(AutoGenerateField = true,Name ="Dernière Modification")]
        public DateTime DerniereModification { get; set; }
        [ForeignKey("PersonneID")]
        [Display(Name = "Modificateur", Description = "Auteur de la dernière modification")]
        public int idModificateur { get; set; }
        //public virtual Utilisateur modificateur { get; set; }



    }
}
