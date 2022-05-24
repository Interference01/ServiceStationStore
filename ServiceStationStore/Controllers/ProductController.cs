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
        public IActionResult Index(string category, int productPage = 1)
        {
            var products = repository.Products
                .Where(p => category == "All" || p.Category.Name == category)
            .OrderBy(p => p.ProductId);
            
            return View(new ProductListViewModel
            {
                Products = products.Skip((productPage - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = products.Count()
                },
                CurrentCategory = category
            });
        }
    }

}

