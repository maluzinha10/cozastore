using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("ListaDesejo")]
public class ListaDesejo
{
    [Key, Column(Order = 1)]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Key, Column(Order = 2)]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Display(Name = "Data de Cadastro")]
    public DateTime DataCadastro { get; set; } = DateTime.Now;
}

