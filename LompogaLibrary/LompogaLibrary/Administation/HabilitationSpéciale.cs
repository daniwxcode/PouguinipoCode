using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LompogaLibrary.Administation
{
    class HabilitationSpéciale
    {
        [Display(Name = "Profil", AutoGenerateField = false, Order = 1, Prompt = "Selectionner le profil concerné", GroupName = "Habilitation", Description = "Profil beneficiant du droit")]
        public int IdUtilisateur { get; set; }

        [Display(Name = "Date de Prise Effet", AutoGenerateField = false, Order = 3, Prompt = "Selectionner le profil concerné", GroupName = "Habilitation", Description = "Date de début de la validité de l'habilitation")]

        public DateTime DateDebut { get; set; }
        [Display(Name = "Date de fin", AutoGenerateField = false, Order = 4, Prompt = @"Entrez la date de fin de l'habilitation", GroupName = "Habilitation", Description = @"Date de fin de validité de l'habilitation")]

        public DateTime DateFin { get; set; }
        public virtual Utilisateur Profil { get; set; }

        
    }
}
