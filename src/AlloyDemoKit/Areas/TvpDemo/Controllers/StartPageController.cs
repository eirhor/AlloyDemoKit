using System.Web.Mvc;
using AlloyDemoKit.Areas.TvpDemo.Models;
using AlloyDemoKit.Controllers;
using AlloyDemoKit.Models.ViewModels;

namespace AlloyDemoKit.Areas.TvpDemo.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        // GET
        public ActionResult Index(StartPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            
            return View("~/Areas/TvpDemo/Views/StartPage/Index.cshtml", model);
        }
    }
}