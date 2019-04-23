using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using LompogaLibrary.Historisable;
namespace LompogaLibrary.Localisation
{
    public class Quartier : Horodatage
    {
        [Key]
        int ID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Le quartier")]
        public string Nom { get; set; }

        public string CodeQuartier { get; }


        // constructeur de quartier
        public Quartier(string _nom)
        {
            Nom = _nom;
            CodeQuartier = Guid.NewGuid().ToString("n");
        }

    }
}
