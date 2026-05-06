using System;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Register page
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // POST: Register form submission
        [HttpPost]
        public ActionResult Register(Registration model)
        {
            // Basic validation
            if (model.Password != model.ConfirmPassword)
            {
                ModelState.AddModelError("", "Passwords do not match");
                return View(model);
            }

            // Role-based logic
            if (model.Role == "Admin")
            {
                // use model.AdminId
            }
            else if (model.Role == "MedicalStaff")
            {
                // use model.MedicalStaffId
            }

            // TODO: Save to database here

            return RedirectToAction("Register");
        }

        // LOGOUT
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();

            return RedirectToAction("Login");
        }

        // LOGIN PAGE
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}