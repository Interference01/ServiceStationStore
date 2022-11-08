using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ServiceStationStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        public bool Shipped { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите регион")]
        public string Region { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите адрес")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите номер телефона")]
        public string NumberPhone { get; set; }
        public bool Pickup { get; set; }
    }
}
