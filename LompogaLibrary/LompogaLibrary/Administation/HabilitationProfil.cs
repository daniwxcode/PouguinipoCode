using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LompogaLibrary.Administation
{
    class HabilitationProfil: Habilitations
    {
        [Display(Name = "Profil", AutoGenerateField = false, Order = 1, Prompt = "Selectionner le profil concerné", GroupName = "Habilitation", Description = "Profil beneficiant du droit")]
        public int IdProfil { get; set; }
        public virtual Profil Profil { get; set; }
    }
}
