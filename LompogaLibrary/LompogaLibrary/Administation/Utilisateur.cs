﻿using System.ComponentModel.DataAnnotations;

namespace LompogaLibrary.Administation
{
    public class Utilisateur : Agent
    {
        [Display(Name = @"Nom d'Utilisateur")]
        string NomUtilisateur { get; set; }

        [Display(Name = @"Mot de passe")]
        [DataType(DataType.Password)]
        string motDePasse { get; set; }

        [Display(Name = @"Activer l'Utlisateur")]
        bool EstActif { get; set; } = false;

    }
}
