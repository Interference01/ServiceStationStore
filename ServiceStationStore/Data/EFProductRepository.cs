using ServiceStationStore.Models;

namespace ServiceStationStore.Data
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ApplicationDBContext context;
        public EFProductRepository(ApplicationDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
