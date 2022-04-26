using Microsoft.AspNetCore.Mvc;
using ServiceStationStore.Data;

namespace ServiceStationStore.Properties
{
    public class HomeController : Controller
    {
        private readonly IProductRepository repository;
        public HomeController(IProductRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}
