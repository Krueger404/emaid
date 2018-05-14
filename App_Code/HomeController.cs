using Emaid.Models;
using System.Net.Mail;
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

            //Generate an email message object to send
            MailMessage email = new MailMessage(model.Email, model.Email);
            email.Subject = string.Format("Emaid Reminder - {0}", model.Subject);
            email.Body = model.Body;

            SmtpClient client = new SmtpClient();
            client.Send(email);

            return RedirectToCurrentUmbracoPage();
        }
    }
}