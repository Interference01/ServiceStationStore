

using System.ComponentModel.DataAnnotations;

namespace ServiceStationStore.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public Category? Category { get; set; }
        public Brand? Brand { get; set; }
        public int Quantity { get; set; }
        public byte[]? Picture { get; set; }
    }
}
