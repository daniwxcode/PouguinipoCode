using LompogaLibrary.Historisable;
using LompogaLibrary.Identité;
using LompogaLibrary.Localisation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LompogaLibrary
{
    [Table("Personnes", Schema = "Ident")]
    public class Personne : Horodatage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonneID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(40,ErrorMessage ="Le nom ne doit pas dépasser 40 caractères")]
        [Display(Name ="Nom",Description ="le Nom de la personne")]
        public string Nom { get; set; }

        [Required(AllowEmptyStrings =false)]
        [MaxLength(75, ErrorMessage = "Le nom ne doit pas dépasser 75 caractères")]
        [Display(Name ="Prénom", Description ="le Prénom de la personne")]
        public string Prénom { get; set; }
        [Display(Name ="Civilité",Description ="La Civilité de la personne")]
        [Required(ErrorMessage ="la Civilité est Obligatoire")]
        public Civilité Civilite { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date de Naissance", Description = "La Date de Naissance de la Personne")]
        public DateTime DateDeNaissance { get; set; }

        [Required(ErrorMessage = "le nom complet de la mère doit être renseigné")]
        [Display(Name = "Nom de la Mère", Description = "Nom et prénom de la mère")]
        [MaxLength(75, ErrorMessage = "Le nom ne doit pas dépasser 75 caractères")]
        public string NomMere { get; set; }

        [Required(ErrorMessage = "le nom complet du père doit être renseigné")]
        [MaxLength(75, ErrorMessage = "Le nom ne doit pas dépasser 75 caractères")]
        [Display(Name = "Nom du père", Description = "Nom et prénom du père")]
        public string NomPere { get; set; }

        [Required(ErrorMessage = "veuillez renseigner les informations de domicile")]
        [MaxLength(200, ErrorMessage = "La description doit tenir sur 200 caractères au plus")]
        [Display(Name = "Indication du domicile", Description = "le Domicile de la personne",Prompt ="Indiquez comment recconnaître le lieu")]

        public string Domicile { get; set; }

        [Required(ErrorMessage = "Veuillez saisir le numero de téléphone")]
        [RegularExpression(@"^[9,7][0-9]{7}$", ErrorMessage = "Veuillez saisir un numero de telephone valide")]
        [Display(Name = "Numéro de Téléphone", Prompt = "Entrer le numéro de téléphone")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Veuillez saisir un mail valide")]
        [Display(Name = "E-mail", Description = "Adresse électrionique", Prompt = @"Saisir l'Email")]
        public string Email { get; set; }

        [ForeignKey("ID")]
        [Display(Name = "Quartier", Description = "le quartier de la peronne")]
        public int QuartierID { get; set; }

        public virtual Quartier Quartier { get; set; }
                          
    }
}
