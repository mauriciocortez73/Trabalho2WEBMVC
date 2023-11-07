using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho2WEBMVC.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Impressoras")]
        public int impressorasID { get; set; }
        [ForeignKey("impressorasID")]
        public Impressora impressoras { get; set; }

        [Required(ErrorMessage = "Campo Quantidades é obrigatório.")]
        [Display(Name = "Quantidades")]
        public int quantidade { get; set; }

        [Display(Name = "Valor")]
        public float valor { get; set; }
    }
}
