using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CozaStore.Models;

[Table("Produto")]
 public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]

        public string Nome { get; set;}

        [Required(ErrorMessage = "Descrição Resumida")]
        [StringLength(60, ErrorMessage = "A Descrição resumida deve possuir no máximo 300 caracteres")]
        public string DescricaoResumida {get; set;}

     [Required(ErrorMessage = "Descrição Completa")]
     [StringLength(60, ErrorMessage = "A Descrição Completa deve possuir no máximo 8000 caracteres")]
    public string DescricaoCompleta{get; set;}
       
    
        [StringLength(60, ErrorMessage = "O SKU deve possuir no máximo 10 caracteres")]
        public string SKU {get; set;}

        [Display(Name = "Preço")]
        [Column(TypeName= "decimal(8,2)")]
        [Required(ErrorMessage = "Informe o Preço da Venda")]
        public decimal Preco {get; set; }

        [Display(Name = "Preço com Desconto")]
        [Column(TypeName= "decimal(8,2)")]
        [Required(ErrorMessage = "Informe o Preço da Venda")]
        public decimal PrecoDesconto {get; set; }

         [Display(Name = "Produto em Destaque?")]
         public bool Destaque {get; set; }

          [Column(TypeName= "decimal(6,3)")]
         public decimal Peso {get; set; }

         [StringLength(30, ErrorMessage = "O Material deve possuir no máximo 30 caracteres")]
         public string Material {get; set;}
         [Display(Name ="Dimensões")]
         [StringLength(20, ErrorMessage ="A dimensão deve possuir no máximo 30 caracteres")]
         public string Dimensao {get; set;}
    }

