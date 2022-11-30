using EverestNerdEducationAndTrainingLLC.IRepositories;
using EverestNerdEducationAndTrainingLLC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EverestNerdEducationAndTrainingLLC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration configuration;
        public UserController(IUserRepository userRepository, IConfiguration _configuration)
        {
            _userRepository = userRepository;
            configuration = _configuration;
        }
        public IActionResult SignIn()
        {
            if(HttpContext.Session.GetInt32("IsUserLoggedIn") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult AuthenticateUser(string Email, string Password)
        {
            var result = _userRepository.AuthenticateUserFromDB(Email, Password);
            if (result != null)
            {
                User userData = _userRepository.GetCustomerByEmail(Email);
                HttpContext.Session.SetString("Email", Email);
                HttpContext.Session.SetString("UserName", userData.UserName);
                HttpContext.Session.SetString("Password", Password);
                HttpContext.Session.SetString("IsUserLoggedIn", result.Token.ToString());
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("SignIn", "User");
        }
        public IActionResult SignUp()
        {
            if (HttpContext.Session.GetString("IsUserLoggedIn") != null)
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
            int data = _userRepository.ContactUs(contact);
            SendEmail(contact);
            return RedirectToAction("Index", "Home");
        }
        public void SendEmail(Contact contactData)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("everestnedredu@gmail.com");
                message.To.Add(new MailAddress("everestnedredu@gmail.com"));
                message.Subject = contactData.Subject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "<div style='text-align:center'><h1>Contact Details</h1><strong>From: </strong><p>http://everestedunow.com/</p></div><br/><br/><strong>Name:</strong> " + contactData.Name + "<br><strong>Email:</strong> " + contactData.Email + "<br><strong>Subjecct: :</strong>" + contactData.Subject + "<br><strong>Message:</strong> " + contactData.Message;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("everestnedredu@gmail.com", "zvqgmsqgbjllwdca");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }
        public IActionResult EditCustomer(string UserEmail)
        {
            if (HttpContext.Session.GetString("IsUserLoggedIn") != null)
            {
                /*string token = HttpContext.Session.GetString("IsUserLoggedIn");
                string configkey = configuration.GetSection("JWT").GetSection("Key").Value;
                string configissuer = configuration.GetSection("JWT").GetSection("Issuer").Value;
                if (_userRepository.IsTokenValid(configkey, configissuer, token))
                {
                    User userData = _userRepository.GetCustomerByEmail(UserEmail);
                    return View(userData);
                }*/
                User userData = _userRepository.GetCustomerByEmail(UserEmail);
                return View(userData);
                return RedirectToAction("Logout", "User");
            }
            return RedirectToAction("SignIn", "User");
        }
        public IActionResult EditCustomerFromDB(User user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.EditCustomer(user);
                HttpContext.Session.SetString("Email", user.Email);
                HttpContext.Session.SetString("UserName", user.UserName);
                HttpContext.Session.SetString("Password", user.Password);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("EditCustomer", "User");
            }
        }
        public IActionResult UserProfile(string UserEmail)
        {
            if (HttpContext.Session.GetString("IsUserLoggedIn") != null)
            {
                User userData = _userRepository.GetCustomerByEmail(UserEmail);
                return View(userData);
            }
            return RedirectToAction("SignIn", "User");
        }
        /*public IActionResult EditFooter()
        {
            var footer = _userRepository.GetFooterById(1);
            return View(footer);
        }
        public IActionResult EditFooterInDB(Footer footer)
        {
            if (HttpContext.Session.GetString("IsUserLoggedIn") != null)
            {
                int footerId = _userRepository.EditFooterInDB(footer);
                if (footerId == null)
                {
                    return RedirectToAction("Home", "Index");
                }
                return RedirectToAction("Logout", "User");
            }
            return RedirectToAction("SignIn", "User");
        }*/

    }   
}
