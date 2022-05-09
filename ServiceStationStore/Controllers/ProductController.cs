using Microsoft.AspNetCore.Mvc;
using ServiceStationStore.Data;
using ServiceStationStore.Models.ModelView;

namespace ServiceStationStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public int PageSize = 5;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(int productPage = 1) => View(new ProductListViewModel
        {
            Products = repository.Products
            .OrderBy(p => p.ProductId)
            .Skip((productPage - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = repository.Products.Count()
            }
        }); 

        
    }
}
