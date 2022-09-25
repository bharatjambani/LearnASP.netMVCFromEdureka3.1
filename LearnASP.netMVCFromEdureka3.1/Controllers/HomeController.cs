using LearnASP.netMVCFromEdureka3._1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnASP.netMVCFromEdureka3._1.Controllers
{
    public class HomeController : Controller
    {
        public IStoreRepository Repo { get; }

        public HomeController(IStoreRepository repo)
        {
            Repo = repo;
        }
        public IActionResult Index()
        {
            var products = Repo.Products;

            return View(products);
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
