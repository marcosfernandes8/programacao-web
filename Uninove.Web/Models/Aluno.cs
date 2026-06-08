using System.ComponentModel.DataAnnotations;

public class Aluno
{
    [Required(ErrorMessage = "Nome é obrigatório")]
    [StringLength(100)]
    public string Nome {get; set; }

    [Required(ErrorMessage = "Email é obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    public string Email {get; set; }

    [Required(ErrorMessage = "RA é obrigatório")]
    [StringLength(20, ErrorMessage = "RA deve ter no máximo 20 caracteres")]
    public string RA {get; set; }

    [Required(ErrorMessage = "Curso é obrigatório")]
    public string Curso {get; set; }

    [Required(ErrorMessage = "Data de nascimento é obrigatória")]
    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    public DateTime DataNascimento {get; set; }

// [Required], [EmailAddress], [StringLength]

}