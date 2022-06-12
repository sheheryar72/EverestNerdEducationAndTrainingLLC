using EverestNerdEducationAndTrainingLLC.IRepositories;
using EverestNerdEducationAndTrainingLLC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EverestNerdEducationAndTrainingLLC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerFeedBackRepository _customerFeedBackRepository;
        public HomeController(ICustomerFeedBackRepository customerFeedBackRepository)
        {
            _customerFeedBackRepository = customerFeedBackRepository;
        }
        public IActionResult Index()
        {
            Serilog.Log.Information("Index Controller Called");
            var result = _customerFeedBackRepository.GetClientFeedBacks();
            if(result.Count > 0)
                return View(result);
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult News()
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }
        public IActionResult OurTeachers()
        {
            return View();
        }
        public IActionResult OurPrograms()
        {
            return View();
        }
        public IActionResult Career()
        {
            return View();
        }
        public IActionResult StudyTips()
        {
            return View();
        }
        public IActionResult Physics()
        {
            return View();
        }
        public IActionResult Biology()
        {
            return View();
        }
        public IActionResult ComputerScience()
        {
            return View();
        }
        public IActionResult Mathemetics()
        {
            return View();
        }
        public IActionResult ReadinAndWriting()
        {
            return View();
        }
    }
}
