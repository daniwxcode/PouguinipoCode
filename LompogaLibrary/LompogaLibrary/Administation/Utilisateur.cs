using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LompogaLibrary.Administation
{
    [Table("Utilisateur", Schema = "Admin")]
    public class Utilisateur : Agent
    {
        [Display(Name = @"Nom d'Utilisateur",Description= "Nom de l'utilisateur", 
            Prompt="Saisir le nom d'utilisateur")]
        string NomUtilisateur { get; set; }

        [Display(Name = @"Mot de passe",Prompt="Saisir le Mot de Passe")]
        [DataType(DataType.Password)]
        string motDePasse { get; set; }

        [Display(Name = @"Activer l'Utlisateur")]
        bool EstActif { get; set; } = false;

    }
}
