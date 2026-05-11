using System.ComponentModel.DataAnnotations;

namespace MERCADO_MVC.Models
{
    public class Mercado
    {
        public int Id { get; set; }

        [Required]
        public string Produto { get; set; }

        public string Descricao { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        [Range(0, 99999)]
        public decimal Preco { get; set; }
    }
}