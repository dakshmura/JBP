using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aadasearch.Models;
using JBD.Models;

namespace JBP.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                // Save user to database or perform other actions
                // For demonstration purposes, let's assume we just return a success message
                ViewBag.Message = "Registration successful!";
                return View();
            }

            // If model validation fails, redisplay the form with validation errors
            return View(model);
        }
    }
}
