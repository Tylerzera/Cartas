using System.ComponentModel.DataAnnotations;

public class CartaDoPapaiNoel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nome da criança é obrigatório.")]
    [StringLength(255, MinimumLength = 3, ErrorMessage = "Nome da criança deve ter entre 3 e 255 caracteres.")]
    public string NomeDaCrianca { get; set; }

    [Required(ErrorMessage = "Endereço da criança é obrigatório.")]
    public string Endereco { get; set; }

    [Range(1, 14, ErrorMessage = "Apenas crianças com menos de 15 anos podem enviar cartas.")]
    public int IdadeDaCrianca { get; set; }

    [Required(ErrorMessage = "Texto da carta é obrigatório.")]
    [StringLength(500, ErrorMessage = "Texto da carta não pode ter mais de 500 caracteres.")]
    public string TextoDaCarta { get; set; }
}
