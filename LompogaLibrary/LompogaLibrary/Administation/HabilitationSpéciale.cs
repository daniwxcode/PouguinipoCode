using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LompogaLibrary.Administation
{
    [Table("HabilitationSpeciale", Schema = "Admin")]
    class HabilitationSpéciale : Habilitations
    {
        

        [Display(Name = "Date de Prise Effet", 
            AutoGenerateField = false, 
            Order = 3, Prompt = "Sélectionner le profil concerné", 
            GroupName = "Habilitation", 
            Description = "Date de début de la validité de l'habilitation")]

        public DateTime DateDebut { get; set; }

        [Display(Name = "Date de fin", 
            AutoGenerateField = false, 
            Order = 4, Prompt = @"Entrez la date de fin de l'habilitation", 
            GroupName = "Habilitation", 
            Description = @"Date de fin de validité de l'habilitation")]

        public DateTime DateFin { get; set; }

        [Display(Name = "Utilisateur", AutoGenerateField = false, Order = 1, Prompt = @"Selectionner l'utilisateur concerné", GroupName = "Habilitation", Description = "Utilisateur beneficiant du droit")]
        public int IdUtilisateur { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }

        
    }
}
