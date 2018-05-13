using EmailForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace EmailForm.Controllers
{
    public class EmailFormController : SurfaceController
    {
        [HttpPost]
        public ActionResult Submit(EmailFormViewModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            // Send the email here

            return RedirectToCurrentUmbracoPage();
        }
    }
}