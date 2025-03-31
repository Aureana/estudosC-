using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreWebApp.Models
{
    public class Produto
    {
        [Key]
        public int idProduto {  get; set; }

        [Required(ErrorMessage = " O campo {} é de preenchimento obrigatório")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = " O campo {} é de preenchimento obrigatório")]
        [MaxLength (1000)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = " O campo {} é de preenchimento obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco {  get; set; }

        [Required(ErrorMessage = " O campo {} é de preenchimento obrigatório")]
        public int Estoque { get; set; }
    }
}
