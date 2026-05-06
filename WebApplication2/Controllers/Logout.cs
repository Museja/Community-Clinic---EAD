using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class LogoutController : Controller
    {
        public ActionResult Logout()
        {
            // Clear session (log user out)
            Session.Clear();
            Session.Abandon();

            // Redirect to Login page
            return RedirectToAction("Login", "Registration");
        }
    }
}