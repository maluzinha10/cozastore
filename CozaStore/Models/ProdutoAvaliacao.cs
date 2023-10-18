using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("ProdutoAvaliacao")]
public class ProdutoAvaliacao
{
    [Key, Column(Order = 1)]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Key, Column(Order = 2)]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Required(ErrorMessage = "Informe o Texto da Avaliação")]
    [StringLength(300, ErrorMessage = "O Texto deve possuir no máximo 300 caracteres")]
    public string AvaliacaoTexto { get; set; }

    [Display(Name = "Data da Avaliação")]
    public DateTime AvaliacaoData { get; set; } = DateTime.Now;

    [Display(Name = "Nota do Produto")]
    public byte? ProdutoNota { get; set; }

}
