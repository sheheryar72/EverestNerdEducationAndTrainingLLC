using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EverestNerdEducationAndTrainingLLC.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodehandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resources you are requested not be found";
                    ViewBag.StatusCode = statusCode;
                    break;
                case 500:
                    ViewBag.ErrorMessage = "Insernal Server Error, Please Contact to Admin";
                    ViewBag.StatusCode = statusCode;
                    break;
            }
            return View();
        }
        /*[Route("Error/505")]
        public IActionResult Error505()
        {
            return View();
        }*/
    }
}
