using Microsoft.AspNetCore.Mvc;
using ServiceStationStore.Models;

namespace ServiceStationStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private readonly Cart cart;

        public CartSummaryViewComponent(Cart cart)
        {
            this.cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
