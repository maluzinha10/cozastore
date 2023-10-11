using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CozaStore.Models;
[Table("Tag")]
    public class Tag    
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id {get; set;}

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(20, ErrorMessage = "O Nome deve possuir no máximo 20 caracteres")]

        public string Nome { get; set;}

          
    }
