using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho2WEBMVC.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório...")]
        [StringLength(35)]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Unidades")]
        public int unidadesID { get; set; }
        [ForeignKey("unidadesID")]
        public Unidade unidades { get; set; }
    }
}
