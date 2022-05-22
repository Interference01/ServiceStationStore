using Microsoft.AspNetCore.Mvc;
using ServiceStationStore.Data;
using ServiceStationStore.Models.ModelView;
using static System.Net.Mime.MediaTypeNames;

namespace ServiceStationStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public int PageSize = 5;
        public ProductController(IProductRepository repo, ApplicationDBContext context)
        {
            repository = repo;
        }
        public IActionResult Index(int productPage = 1)
        {
            return View(new ProductListViewModel
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
}
