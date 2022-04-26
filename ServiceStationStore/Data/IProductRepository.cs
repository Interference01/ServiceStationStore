using ServiceStationStore.Models;

namespace ServiceStationStore.Data
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
