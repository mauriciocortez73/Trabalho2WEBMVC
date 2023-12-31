﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho2WEBMVC.Models
{
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

        [Required(ErrorMessage = "Campo Cor é obrigatório...")]
        [StringLength(35)]
        [Display(Name = "Cor")]
        public string cor { get; set; }
    }
}
