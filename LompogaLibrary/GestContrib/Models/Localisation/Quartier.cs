using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using LompogaLibrary.Historisable;
namespace LompogaLibrary.Localisation
{
    [Table("Quariers", Schema = "Loc")]
    public class Quartier 
    {
        [Key]
        public int QuartierID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Le quartier")]
        public string NomQuartier { get; set; }
        [Display(AutoGenerateField =true)]
        public string CodeQuartier { get; }= Guid.NewGuid().ToString("n");




    }
}
