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
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso", Prompt = "Informe a sua Senha para Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha de Acesso")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "A Senha deve possuir no minimo 6 e no máximo 20 caracteres")]
    public string Senha { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirmar senha de Acesso", Prompt = "Confirme sua Senha de Acesso")]
    [Compare("Senha", ErrorMessage = "As Senhas não Conferem")]
    public string ConfirmacaoSenha { get; set; }

    public IFormFile Foto { get; set; }

    public bool Termos { get; set; } = false;

    public bool Enviado { get; set; } = false;
}