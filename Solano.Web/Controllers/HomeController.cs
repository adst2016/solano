using Infrastructure.Fundamental.ControllerBase;
using System.Security.Claims;
using System.Web.Mvc;

//using Solano.Web.Areas.Administration.Services;

namespace Solano.Web.Controllers
{
    public class HomeController : AppControllerBase
    {
        //private readonly IAdministrationService administrationService;

        //public HomeController(IAdministrationService administrationService)
        //{
        //    this.administrationService = administrationService;
        //}

        public ActionResult Index()
        {
            
            if (CurrentUser.Identity.IsAuthenticated)
            {
                var id = CurrentUser.Id;
            }

            //IPrincipal threadPrincipal = Thread.CurrentPrincipal;

            ClaimsPrincipal icp = this.User as ClaimsPrincipal;
            //ClaimsPrincipal icp = Thread.CurrentPrincipal as ClaimsPrincipal;

            var claim = icp.FindFirst(ClaimTypes.NameIdentifier);

            //Request.GetOwinContext().Authentication.User.Claims

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