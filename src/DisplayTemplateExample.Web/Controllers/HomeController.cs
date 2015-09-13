using System.Collections.Generic;
using System.Web.Mvc;
using DisplayTemplateExample.Web.Models;

namespace DisplayTemplateExample.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new ViewModel
            {
                Tiles = new List<ITile>
                {
                    new ImageTile {src = "/Content/smpl.jpg" },
                    new TextTile {Text = "Sample text a" },
                    new TextTile {Text = "awesome text b" }
                }
            };
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}