using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LompogaLibrary.Administation
{
    [Table("HabilitationProfil", Schema = "Admin")]
    class HabilitationProfil: Habilitations
    {
        [Display(Name = "Profil", AutoGenerateField = false, Order = 1,
            Prompt = "Sélectionner le profil concerné",
            GroupName = "Habilitation", 
            Description = "Profil béneficiant du droit")]
        [ForeignKey("IDProfil")]
        public int IdProfil { get; set; }
        public virtual Profil Profil { get; set; }
    }
}
