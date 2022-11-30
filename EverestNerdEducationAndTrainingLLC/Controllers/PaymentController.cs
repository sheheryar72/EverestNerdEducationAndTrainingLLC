using EverestNerdEducationAndTrainingLLC.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EverestNerdEducationAndTrainingLLC.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IWebsiteContent _websiteContent;
        public PaymentController(IWebsiteContent websiteContent)
        {
            _websiteContent = websiteContent;
        }
        public IActionResult Index()
        {
            var result = _websiteContent.GetBankDetails();
            return View(result);
        }
    }
}
