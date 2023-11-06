using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho2WEBMVC.Models
{
    [Table("Unidades")]
    public class Unidade
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Descricao é obrigatório...")]
        [StringLength(35)]
        [Display(Name = "Descricao")]
        public string descricao { get; set; }
        //
        [Required(ErrorMessage = "Campo CNPJ é obrigatório...")]
        [StringLength(18)]
        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }
    }
}
