using System.Web.Mvc;
using log4net;
using Solano.Web.Areas.Administration.Services;

namespace Solano.Web.Controllers
{    
    public class HomeController : Controller
    {
        private readonly IAdministrationService administrationService;

        public HomeController(IAdministrationService administrationService)
        {
            this.administrationService = administrationService;
        }

        public ActionResult Index()
        {
            string name = this.administrationService.GetName(1);

            return View();
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