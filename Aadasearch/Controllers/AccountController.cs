using Aadasearch.Models;
using Microsoft.AspNetCore.Mvc;


public class AccountController : Controller
{
    // GET: /Account/Register
    public ActionResult Register()
    {
        return View();
    }

    // POST: /Account/Register
    [HttpPost]
    public ActionResult Register(UserModel model)
    {
        if (ModelState.IsValid)
        {
            // Save the user to the database or perform other actions
            // For simplicity, let's just assume we save the user here
            // Replace this with your actual database logic
            // For demonstration purposes, I'm just printing the username and password
            Console.WriteLine("Registered User: " + model.Username);
            Console.WriteLine("Password: " + model.Password);
            Console.Write("Successful Registration");
            
            return RedirectToAction("Login");
        }

        return View(model);
    }

    // GET: /Account/Login
    public ActionResult Login()
    {
        return View();
    }

    // POST: /Account/Login
    [HttpPost]
    public ActionResult Login(UserModel model)
    {
        if (ModelState.IsValid)
        {
            // Here, you would typically validate the user credentials against your database
            // For simplicity, let's assume the login is successful if the username and password are not empty
            if (!string.IsNullOrEmpty(model.Username) && !string.IsNullOrEmpty(model.Password))
            {
                // Authentication successful, you can set session variables or cookies here
                return RedirectToAction("Index", "Home"); // Redirect to home page after successful login
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password");
            }
        }

        return View(model);
    }
}
