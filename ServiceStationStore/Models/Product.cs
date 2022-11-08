

using System.ComponentModel.DataAnnotations;

namespace ServiceStationStore.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите наименование товара")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите описание")]
        public string? Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста введите положительное значение цены")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Пожалуйста укажите категорию")]
        public Category? Category { get; set; }
        //[Required(ErrorMessage = "Пожалуйста укажите брэнд")]
        public Brand? Brand { get; set; }
        //[Required(ErrorMessage = "Пожалуйста укажите количество доступных товаров")]
        public int Quantity { get; set; }
        public byte[]? Picture { get; set; }
    }
}