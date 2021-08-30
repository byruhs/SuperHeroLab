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
            HeroResponse heroResponse = _search.GetHero(id);
            return View(heroResponse);
        }
    }
}
