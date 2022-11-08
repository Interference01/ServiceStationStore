using Microsoft.EntityFrameworkCore;
using ServiceStationStore.Models;

namespace ServiceStationStore.Data
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDBContext context;
        public EFOrderRepository(ApplicationDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders.Include(o => o.Lines).ThenInclude(l => l.Product);

        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderId == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}