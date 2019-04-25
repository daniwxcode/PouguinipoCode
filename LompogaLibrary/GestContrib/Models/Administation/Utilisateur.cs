using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LompogaLibrary.Administation
{
    [Table("Utilisateur", Schema = "Admin")]
    public class Utilisateur : Agent
    {
        [Display(Name = @"Nom d'Utilisateur",Description= "Nom de l'utilisateur", 
            Prompt="Saisir le nom d'utilisateur")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Le nom d'utilisateur est obligatoire")]
       public string NomUtilisateur { get; set; }

        [Display(Name = @"Mot de passe",Prompt="Saisir le Mot de Passe")]
        [DataType(DataType.Password,ErrorMessage ="Veuillez Saisir un mot de passe valide")]
        [Required(ErrorMessageResourceName = "Mode de Passe")]
       public string motDePasse { get; set; }

        [NotMapped]
        [Compare("motDePasse",ErrorMessage ="Les mots de passe ne correspondent pas")]
        [Display(Name = @"Mot de passe", Prompt = "Saisir le Mot de Passe")]
        [Required(ErrorMessageResourceName ="Mode de Passe")]
        [DataType(DataType.Password, ErrorMessage = "Veuillez Saisir à nouveau votre mot de passe")]
        public string ConfirmPassword { get; set; }
        [Display(Name = @"Activer l'Utlisateur")]
        public bool EstActif { get; set; } = false;

       public  ICollection<HabilitationProfil> HabilitationsProfil { get; set; }
       public ICollection<HabilitationSpéciale> HabilitationSpéciales { get; set; }

    }
}
