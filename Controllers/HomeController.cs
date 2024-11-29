using Microsoft.AspNetCore.Mvc;

namespace Bafana_Qhoboshiyane.Controllers
{
    public class HomeController : Controller
    {
        // Action for the Home page (Index)
        public IActionResult Index()
        {
            return View(); // This will return the Index.cshtml view from Views/Home
        }

        // Action for the About Me page
        public IActionResult AboutMe()
        {
            return View("About Me"); // This will return the "About Me.cshtml" view from Views/Home
        }

        // Action for the Contact Me page
        public IActionResult ContactMe()
        {
            return View("Contact Me"); // This will return the "Contact Me.cshtml" view from Views/Home
        }

        // Action for the Portfolio page
        public IActionResult Portfolio()
        {
            return View("Portfolio"); // This will return the "Portfolio.cshtml" view from Views/Home
        }
    }
}
