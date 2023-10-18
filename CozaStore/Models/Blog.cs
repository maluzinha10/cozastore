using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Blog")]
public class Blog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Informe o Texto")]
    [StringLength(600, ErrorMessage = "O Texto deve possuir no máximo 600 caracteres")]
    public string Texto { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

    [Display(Name = "Autor")]
    [Required(ErrorMessage = "Informe o Autor")]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Display(Name = "Data de Cadastro")]
    public DateTime DataCadastro { get; set; } = DateTime.Now;
}
