using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LompogaLibrary.Administation
{
    [Table("HabilitationProfil", Schema = "Admin")]
    public class HabilitationProfil: Habilitations
    {
        [Column(Order =2)]
        [Display(Name = "Profil", AutoGenerateField = false, Order = 1,
            Prompt = "Sélectionner le profil concerné",
            GroupName = "Habilitation", 
            Description = "Profil béneficiant du droit")]
        [ForeignKey("IDProfil")]
        public int IdProfil { get; set; }
        public virtual Profil Profil { get; set; }

    }
}
