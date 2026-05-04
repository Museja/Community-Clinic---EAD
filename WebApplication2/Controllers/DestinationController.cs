using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class PatientController : Controller
    {
        public ActionResult PatientData()
        {
            return View();
        }
    }
}