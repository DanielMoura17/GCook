using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels;

public class RegistroVM
{
    [Display(Name = "Nome Completo", Prompt = "Informe seu Nome Completo")]
    [Required(ErrorMessage = "Por favor, informe seu Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Email {get; set;}

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento", Prompt = "Informe sua Data de Nascimento")]
    [Required(ErrorMessage = "Por favor, informe sua Dta de Nascimento")]
    public DateTime? DataNascimento { get; set;} = null;

    [Display(Prompt = "Informe seu Email")]
    [Required(ErrorMessage = "Por favor, informe seu Email")]
    [EmailAddress(ErrorMessage = "Por favor, informe um Email válido")]
    [StringLength(100, ErrorMessage = "O email deve possuir no máximo 100 caracteres")]
    public string Email { get; set;}

    
}