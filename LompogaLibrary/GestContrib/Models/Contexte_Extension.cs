using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LompogaLibrary.Administation;
using LompogaLibrary.Extensions;
using LompogaLibrary.Localisation;

namespace GestContrib.Models
{
    public static class Contexte_Extension
    {
        private static List<Droits> lesDroits = new List<Droits>()
        {
            new Droits
            {
                LibelleDroit ="Connexion"
            },
            new Droits
            {
                LibelleDroit ="Modifier Mot de Passe"
            }
            

        };


        private static List<Quartier> Quartiers = new List<Quartier>()
        {
            new Quartier()
            {
                NomQuartier ="Quartier de Démo",


            }
        };
        private static Utilisateur SuperUser = new Utilisateur()
        {
            Nom = "SuperUser",
            Prénom = "SuperUser",
            Email = "SuperUser@Lompogal.com",
            Civilite = LompogaLibrary.Identité.Civilité.Monsieur,
            motDePasse = "SuperUser".Crypter(),
            DateDeNaissance = DateTime.Now,
            DateCréation = DateTime.Now,
            NomMere = "SuperUser",
            NomPere = "SuperUser",
            Poste = "SuperUser",
            EstActif = true,
            Telephone = "91378364",
            ConfirmPassword = "SuperUser",
            NomUtilisateur = "Admin"

        };

        public static void DataInit (this Contexte _contexte)
        {
            if (_contexte.Personnes.Any())
            {
                return;
            }

            var Droits = new List<Droits>()
            {
                new Droits
                {
                    LibelleDroit="Connexion",

                }
            };
        }
    }
}
