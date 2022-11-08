using ServiceStationStore.Infrastructure;
using System.Text.Json.Serialization;

namespace ServiceStationStore.Models
{
    public class SessionCart : Cart
    {

        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();
            cart.session = session;
            return cart;
        }

        [JsonIgnore]
        private ISession session { get; set; }
        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            session.SetJson("Cart", this);
        }
        public override void RemoveLine(Product product)
        {
            base.RemoveLine(product);
            session.SetJson("Cart", this);
        }
        public override void Clear()
        {
            base.Clear();
            session.Remove("Cart");
        }

    }
}
