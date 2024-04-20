using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aadasearch.Models;
using JBD.Models;
using JBP.Models;

namespace JBP.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Here you would typically validate the user's credentials
                // For demonstration purposes, let's assume we just return a success message
                ViewBag.Message = "Login successful!";
                return View();
            }

            // If model validation fails, redisplay the form with validation errors
            return View(model);
        }
    }
}
