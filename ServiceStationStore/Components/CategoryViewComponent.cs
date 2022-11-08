using Microsoft.AspNetCore.Mvc;
using ServiceStationStore.Data;
using ServiceStationStore.Models.ModelView;

namespace ServiceStationStore.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly IProductRepository repository;

        public CategoryViewComponent(IProductRepository repository)
        {
            this.repository = repository;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData.Values["category"];
            return View(repository.Products
                .Select(x => x.Category.Name)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
