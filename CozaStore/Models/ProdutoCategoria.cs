using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CozaStore.Models;

[Table("ProdutoCategoria")]

    public class ProdutoCategoria
    {
        [Key, Column(Order = 1)]
       public int ProdutoId { get; set; } 
       [ForeignKey("ProdutoId")]
       public Produto Produto {get; set;}

        [Key, Column(Order = 2)]
       public byte CategoriaId { get; set; }
       [ForeignKey("CategoriaId")]
       public Categoria Categoria {get; set;}
    }
