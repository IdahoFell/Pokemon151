using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Pokemon151.Controllers
{
    public class PokemonController : Controller
    {
        // 
        // GET: /Pokemon/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /Pokemon/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
