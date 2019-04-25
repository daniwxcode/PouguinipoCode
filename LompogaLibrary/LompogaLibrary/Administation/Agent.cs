namespace LompogaLibrary.Administation
{
    [Table("Agent", Schema = "Admin")]
    public class Agent: Personne
    {
        
        [Display(AutoGenerateField = false, Name = "Poste", Description = "Le Poste occupé", Prompt = "Renseigner Le Poste occupé", Order = 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Veuillez Renseigner la personne")]
        protected string Poste { get; set; }

        protected virtual Personne Personne { get; set; }
    }
}
