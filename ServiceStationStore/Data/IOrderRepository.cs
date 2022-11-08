using ServiceStationStore.Models;

namespace ServiceStationStore.Data
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
