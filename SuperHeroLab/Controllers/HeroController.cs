using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroLab.Data.Interface;
using SuperHeroLab.Data.Model;

namespace SuperHeroLab.Controllers
{
    public class HeroController : Controller
    {
        private IHeroSearch _search;

        public HeroController(IHeroSearch _search)
        {
            this._search = _search;
        }

        [HttpGet("character/{id}")]
        public IActionResult Search(int id)
        {
            ViewData["value"] = HttpContext.Session.GetString("value");

            HeroResponse heroResponse = _search.GetHero(id);
            if (heroResponse.Response.Equals("error"))
            {
                ViewBag.Message = "Invalid hero or villian";
                return View("_NotFound");
            }
            return View(heroResponse);
        }
    }
}
