using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroLab.Data.Interface;
using SuperHeroLab.Data.Model;

namespace SuperHeroLab.Controllers
{
    public class HomeController : Controller
    {
        private ISearch _search;

        public HomeController(ISearch _search)
        {
            this._search = _search;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string value)
        {
            ViewData["value"] = value;

            HttpContext.Session.SetString("value", value);

            SearchResponse searchResponse = _search.GetHeroList(value);
            return View(searchResponse);
        }
    }
}
