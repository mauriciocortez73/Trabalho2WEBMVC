using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho2WEBMVC.Models
{
    enum Cores { Preto, Colorido }

    [Table("Tonners")]
    public class Tonner
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Descricao é obrigatório...")]
        [StringLength(35)]
        [Display(Name = "Descricao")]
        public string descricao { get; set; }

        [Display(Name = "Cores")]
        public int Cores { get; set; }

        [Display(Name = "Impressoras")]
        public int impressorasID { get; set; }
        [ForeignKey("impressorasID")]
        public Impressora impressoras { get; set; }
    }
}
