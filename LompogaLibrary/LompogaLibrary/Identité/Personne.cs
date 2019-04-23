using LompogaLibrary.Historisable;
using LompogaLibrary.Identité;
using LompogaLibrary.Localisation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LompogaLibrary
{
    public class Personne : Horodatage
    {
        [Key]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name ="Nom",Description ="le Nom de la personne")]
        public string Nom { get; set; }

        [Required(AllowEmptyStrings =false)]
        [Display(Name ="Prénom", Description ="le Prénom de la personne")]
        public string Prénom { get; set; }
        [Display(Name ="Civilité",Description ="La Civilité de la personne")]
        [Required(ErrorMessage ="la Civilité est Obligatoire")]
        public Civilité Civilite { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Date de Naissance",Description ="La Date de Naissance de la Personne")]
        public DateTime DateDeNaissance { get; set; }

        [Required(ErrorMessage ="le nom complet de la mère doit être renseigné")]
        [Display(Name ="Nom de la Mère",Description ="Nom et prénom de la mère")]
        public string NomMere { get; set; }

        [Required(ErrorMessage = "le nom complet du père doit être renseigné")]
        [Display(Name = "Nom du père", Description = "Nom et prénom du père")]
        public string NomPere { get; set; }

        [Required(ErrorMessage = "veuillez renseigner les informations de domicile")]
        [Display(Name = "Indication du domicile", Description = "le Domicile de la personne")]
        public string Domicile { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name ="E-mail",Description ="Adresse électrionique")]
        public string? Email { get; set; }

        [ForeignKey("ID")]
        [Display(Name ="Quartier",Description ="le quartier de la peronne")]
        public int? QuartierID { get; set; }

        public virtual Quartier? Quartier { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField =true)]
        public Guid Guid { get; set; }


       

    }
}
