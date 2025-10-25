using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Ecommerce.Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }  // Chave primária

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;  // Nome do produto

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;  // Descrição do produto

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }  // Preço

        [Required]
        [Range(0, int.MaxValue)]
        public int Stock { get; set; }  // Quantidade em estoque

        [MaxLength(50)]
        public string Category { get; set; } = string.Empty;  // Categoria do produto
    }
}
