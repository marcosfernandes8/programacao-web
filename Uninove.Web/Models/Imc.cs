using System.ComponentModel.DataAnnotations;

public class ImcViewModel
{
    [Required(ErrorMessage = "Peso é obrigatório")]
    public double Peso { get; set; }

    [Required(ErrorMessage = "Altura é obrigatória")]
    public double Altura { get; set; }

    public double Resultado { get; set; }

    public string? Classificacao { get; set; }
}