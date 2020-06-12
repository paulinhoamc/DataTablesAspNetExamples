using System;
using System.ComponentModel.DataAnnotations;

namespace DataTablesMvcCore.DataModel
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(2)]
        public string UF { get; set; }

        [Required]
        [MaxLength(10)]
        public string NCM { get; set; }

        [MaxLength(200)]
        [Required]
        public string Nome { get; set; }
        
        public decimal Municipal { get; set; }
        
        public decimal Estadual { get; set; }
        
        public decimal Federal { get; set; }
        
        public decimal Importacao { get; set; }
        
        public string Versao { get; set; }
        
        public DateTime Inicio { get; set; }
        
        public DateTime Termino { get; set; }
    }
}
