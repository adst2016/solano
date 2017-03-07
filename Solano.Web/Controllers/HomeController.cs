using System.Web.Mvc;
using log4net;
using Infrastructure.Common.Logging;

namespace Solano.Web.Controllers
{    
    public class HomeController : Controller
    {        
        private readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);        

        public ActionResult Index()
        {            
            log.Info("fdsaJJKLJLeeeeeeeeeeK");
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