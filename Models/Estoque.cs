using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho2WEBMVC.Models
{
    [Table("Estoques")]
    public class Estoque
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Quantidades é obrigatório.")]
        [Display(Name = "Quantidades")]
        public int quantidade { get; set; }
    }
}
