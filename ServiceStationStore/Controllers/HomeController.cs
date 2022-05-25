using Microsoft.AspNetCore.Mvc;
using ServiceStationStore.Data;

namespace ServiceStationStore.Properties
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
