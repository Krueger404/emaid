using Emaid.Models;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Emaid.Controllers
{
    public class HomeSurfaceController : SurfaceController
    {
        [HttpPost]
        public ActionResult Submit(HomeViewModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            // Send the email here

            return RedirectToCurrentUmbracoPage();
        }
    }
}