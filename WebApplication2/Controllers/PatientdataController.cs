using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PatientdataController : Controller
    {
        [HttpGet]
        public ActionResult PatientData()
        {
            return View(new Patient());
        }

        // SAVE PATIENT (replaces Save_Click)
        [HttpPost]
        public ActionResult SavePatient(Patient model)
        {
            // VALIDATION (same as WinForms)

            if (string.IsNullOrWhiteSpace(model.Name))
            {
                ModelState.AddModelError("", "Name is required");
                return View("PatientData", model);
            }

            if (model.Age <= 0)
            {
                ModelState.AddModelError("", "Enter a valid age");
                return View("PatientData", model);
            }

            if (model.DateOfBirth == DateTime.MinValue)
            {
                ModelState.AddModelError("", "Enter a valid Date of Birth");
                return View("PatientData", model);
            }

            if (string.IsNullOrWhiteSpace(model.PhoneNumber))
            {
                ModelState.AddModelError("", "Phone number is required");
                return View("PatientData", model);
            }

            if (string.IsNullOrWhiteSpace(model.EmailAddress) || !model.EmailAddress.Contains("@"))
            {
                ModelState.AddModelError("", "Enter a valid email");
                return View("PatientData", model);
            }

            // SAVE TO DATABASE
            PatientDAL dal = new PatientDAL();
            dal.AddPatient(model);

            TempData["Success"] = "Patient saved successfully!";

            return RedirectToAction("PatientData");
        }

        // UPDATE PATIENT (replaces Update_Click)
        [HttpPost]
        public ActionResult UpdatePatient(Patient model)
        {
            PatientDAL dal = new PatientDAL();
            dal.UpdatePatient(model);

            TempData["Success"] = "Patient updated successfully!";

            return RedirectToAction("PatientData");
        }

        // CLEAR FORM (replaces Clear_Click)
        [HttpPost]
        public ActionResult ClearForm()
        {
            return RedirectToAction("PatientData");
        }
    }
}