using EverestNerdEducationAndTrainingLLC.IRepositories;
using EverestNerdEducationAndTrainingLLC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EverestNerdEducationAndTrainingLLC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult SignIn()
        {
            if(HttpContext.Session.GetInt32("IsUserLoggedIn") == 1)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult AuthenticateUser(string Email, string Password)
        {
            bool result = _userRepository.AuthenticateUserFromDB(Email, Password);
            if (result)
            {
                HttpContext.Session.SetString("Email", Email);
                HttpContext.Session.SetString("Password", Password);
                HttpContext.Session.SetInt32("IsUserLoggedIn", 1);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("SignIn", "User");
        }
        public IActionResult SignUp()
        {
            if (HttpContext.Session.GetInt32("IsUserLoggedIn") == 1)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult RegisterUser(User user)
        {
            if (ModelState.IsValid)
            {
                int result = _userRepository.AddCustomer(user);
                if(result > 0)
                {
                    return RedirectToAction("SignIn", "User");
                }
                return RedirectToAction("SignUp", "User");
            }
            return RedirectToAction("SignUp", "User");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Email");
            HttpContext.Session.Remove("Password");
            HttpContext.Session.Remove("IsUserLoggedIn");
            return RedirectToAction("SignIn", "User");
        }
        public IActionResult ContactUs(Contact contact)
        {
            if (ModelState.IsValid)
            {
                int data = _userRepository.ContactUs(contact);
                if(data > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                return RedirectToAction("ContactUs", "Home");
            }
            return RedirectToAction("ContactUs", "Home");
        }

    }
}
