using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("ProdutoFoto")]
public class ProdutoFoto
{
    [Key, Column(Order = 1)]
    public int Id { get; set; }

    [Key, Column(Order = 2)]
    [Required(ErrorMessage = "Informe o Produto")]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Required]
    [StringLength(300)]
    public string ArquivoFoto { get; set; }

    [Display(Name = "Foto Destaque?")]
    public bool Destaque { get; set; } = false;
}
