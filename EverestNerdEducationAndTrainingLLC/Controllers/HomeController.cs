using EverestNerdEducationAndTrainingLLC.IRepositories;
using EverestNerdEducationAndTrainingLLC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;

namespace EverestNerdEducationAndTrainingLLC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerFeedBackRepository _customerFeedBackRepository;
        private readonly IWebsiteContent _websiteContent;
        private readonly IJobRepository _jobRepository;
        public HomeController(ICustomerFeedBackRepository customerFeedBackRepository, IWebsiteContent websiteContent, IJobRepository jobRepository)
        {
            _websiteContent = websiteContent;
            _customerFeedBackRepository = customerFeedBackRepository;
            _jobRepository = jobRepository;
        }
        public IActionResult Index()
        {
            Serilog.Log.Information("Index Controller Called");
            var result1 = _customerFeedBackRepository.GetClientFeedBacks();
            var result2 = _websiteContent.GetAllCourses();
            var result3 = _websiteContent.GetFooter();
            var result4 = _websiteContent.GetAllHomePageContentDetails();
            HomePageContent homePageContent = new HomePageContent();
            homePageContent.clientFeedBacks = result1;
            homePageContent.courses = result2;
            homePageContent.homePageContentDetails = result4;

            HttpContext.Session.SetString("FooterEmail", result3.Email);
            HttpContext.Session.SetString("FooterAddress", result3.Address);
            HttpContext.Session.SetString("FooterPhone", result3.Phone);
            HttpContext.Session.SetString("FooterFacebook", result3.Facebook);
            HttpContext.Session.SetString("FooterInstagram", result3.Instagram);
            HttpContext.Session.SetString("FooterGoogle", result3.Google);
            HttpContext.Session.SetString("FooterTwitter", result3.Twitter);
            HttpContext.Session.SetString("FooterDiscription", result3.Discription);

            if (result1 != null)
                return View(homePageContent);
            return View();
        }
        public IActionResult EditHomePage()
        {
            var data = _websiteContent.GetAllHomePageContentDetails();
            return View(data);
        }
        public IActionResult UpdateHomePage(HomePageContentDetails home)
        {
            _websiteContent.UpdateHomePageContentDetails(home);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AboutUs()
        {
            var result = _websiteContent.GetAboutUs();
            return View(result);
        }
        public IActionResult EditAboutUs()
        {
            var result = _websiteContent.GetAboutUs();
            return View(result);
        }
        public IActionResult UpdateAboutUs(AboutUs aboutUs)
        {
            _websiteContent.UpdateAboutUs(aboutUs);
            return RedirectToAction("AboutUs", "Home");
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult News()
        {
            var result = _websiteContent.GetAllNews();
            return View(result);
        }
        public IActionResult AddNews()
        {
            return View();
        }
        public IActionResult InsertNewsInDB(News news)
        {
            _websiteContent.InsertNewsInDB(news);
            return RedirectToAction("News", "Home");
        }
        public IActionResult EditNews(int Id)
        {
            var result = _websiteContent.GetNewsById(Id);
            return View(result);
        }
        public IActionResult DeleteNews(int Id)
        {
            var result = _websiteContent.DeleteNews(Id);
            return View(result);
        }
        public IActionResult UpdateNews(News news)
        {
            var result = _websiteContent.EditNewsInDB(news);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Events()
        {
            return View();
        }
        public IActionResult OurTeachers()
        {
            var data = _websiteContent.GetAllTeacher();
            return View(data);
        }
        public IActionResult OurPrograms()
        {
            var result = _websiteContent.GetAllCourses();
            return View(result);
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
            var result = _websiteContent.GetCoursesById(1);
            return View(result);
        }
        public IActionResult Biology()
        {
            var result = _websiteContent.GetCoursesById(2);
            return View(result);
        }
        public IActionResult ComputerScience()
        {
            var result = _websiteContent.GetCoursesById(3);
            return View(result);
        }
        public IActionResult Mathemetics()
        {
            var result = _websiteContent.GetCoursesById(4);
            return View(result);
        }
        public IActionResult ReadinAndWriting()
        {
            var result = _websiteContent.GetCoursesById(5);
            return View(result);
        }
        public IActionResult EditFooter()
        {
            if (HttpContext.Session.GetString("IsUserLoggedIn") != null)
            {
            Footer footer = _websiteContent.GetFooter();
            return View(footer);
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult EditFooterInDB(Footer footer)
        {
            if (HttpContext.Session.GetString("IsUserLoggedIn") != null)
            {
                 if (ModelState.IsValid)
                {
                    int result = _websiteContent.EditFooterInDB(footer);
                    if (result > 0)
                    {
                        HttpContext.Session.SetString("FooterEmail", footer.Email);
                        HttpContext.Session.SetString("FooterAddress", footer.Address);
                        HttpContext.Session.SetString("FooterPhone", footer.Phone);
                        HttpContext.Session.SetString("FooterFacebook", footer.Facebook);
                        HttpContext.Session.SetString("FooterInstagram", footer.Instagram);
                        HttpContext.Session.SetString("FooterGoogle", footer.Google);
                        HttpContext.Session.SetString("FooterTwitter", footer.Twitter);
                        HttpContext.Session.SetString("FooterDiscription", footer.Discription);
                        return RedirectToAction("Index", "Home");
                    }
                    return RedirectToAction("EditFooter", "Home");
                }
                return RedirectToAction("AddFooter", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult EditCourse(int Id)
        {
            if (HttpContext.Session.GetString("IsUserLoggedIn") != null)
            {
                var result = _websiteContent.GetCoursesById(Id);
                return View(result);
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult EditCourseInDB(Course course)
        {
            if (HttpContext.Session.GetString("IsUserLoggedIn") != null)
            {
                if (ModelState.IsValid)
                {
                    int result = _websiteContent.EditCourseInDB(course);
                    if (result > 0)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return RedirectToAction("EditCourse", "Home");
                }
                return RedirectToAction("EditCourse", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult EditTeacher(int Id)
        {
            if (HttpContext.Session.GetString("IsUserLoggedIn") != null)
            {
                var result = _websiteContent.GetTeacherById(Id);
                return View(result);
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult EditTeacherInDB(Teacher teacher)
        {
            if (HttpContext.Session.GetString("IsUserLoggedIn") != null)
            {
                if (ModelState.IsValid)
                {
                    int result = _websiteContent.EditTeacherInDB(teacher);
                    if (result > 0)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return RedirectToAction("EditTeacher", "Home");
                }
                return RedirectToAction("EditTeacher", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
        /*public IActionResult FindWork()
        {
            var result = _jobRepository.GetJobs();
            if(result != null)
            {
                return View(result);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }*/
        public IActionResult CurrentJobOpenings()
        {
            var result = _jobRepository.GetJobs();
            if(result != null)
            {
                return View(result);
            }
            return View();
        }
        public ActionResult EmploymentApplication(int? Id)
        {
            ViewBag.jobId = Id;
            return View();
        }
        public ActionResult InsertEmploymentApplication(ApplyJobs applyJobs)
        {
            //_jobRepository.AppliedJob(applyJobs);
            SendEmployApplication(applyJobs);
            return RedirectToAction("Index", "Home");
        }
        public void SendEmployApplication(ApplyJobs applyJobs)
        {
            try
            {
                IHostingEnvironment env = null;
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("everestnedredu@gmail.com");
                message.To.Add(new MailAddress("everestnedredu@gmail.com"));
                message.Subject = applyJobs.AppliedFor;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "<div style='text-align:center'><h1>Application Details</h1><strong>From: </strong><p>http://everestedunow.com/</p></div><br/><br/><strong>Name:</strong> " + applyJobs.FullName + "<br><strong>Email:</strong> " + applyJobs.Email + "<br><strong>Applied For: </strong>" + applyJobs.AppliedFor +
                 "<br><strong>Experience:</strong> " + applyJobs.Experience + "<br><strong>Message:</strong> " + applyJobs.Message;
                if (applyJobs.CV != null)
                {
                    message.Attachments.Add(new Attachment(applyJobs.CV.OpenReadStream(), applyJobs.CV.FileName));
                }
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
        public ActionResult AddJobs(int? Id)
        {
            if (HttpContext.Session.GetInt32("IsUserLoggedIn") != null)
            {
                if (Id > 0)
                {
                    var job = _jobRepository.GetSingleJob(Id);
                    return View(job);
                }
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult EditJobById(int? Id)
        {
            if (HttpContext.Session.GetInt32("IsUserLoggedIn") != null)
            {
                if (Id > 0)
                {
                    var job = _jobRepository.GetSingleJob(Id);
                    return View(job);
                }
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult DeleteJobById(int? Id)
        {
            if (HttpContext.Session.GetInt32("IsUserLoggedIn") != null)
            {
                if (Id > 0)
                {
                    _jobRepository.DeleteJob(Id);
                    return RedirectToAction("FindWork", "Home");
                }
                return RedirectToAction("FindWork", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult AddJobsInDB(Jobs jobs)
        {
            if (HttpContext.Session.GetInt32("IsUserLoggedIn") != null)
            {
                if (jobs.Id != 0)
                {
                    int id = _jobRepository.EditJob(jobs);
                    if (id > 0)
                    {
                        return RedirectToAction("FindWork", "Home");
                    }
                    return RedirectToAction("AddJobs", "Home");
                }
                else
                {
                    int id = _jobRepository.AddJobs(jobs);
                    if (id > 0)
                    {
                        return RedirectToAction("FindWork", "Home");
                    }
                    return RedirectToAction("AddJobs", "Home");
                }
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult EditBankDetails(int? Id)
        {
           var result = _websiteContent.GetBankDetails();
            return View(result);
        }
        public ActionResult UpdateBankDetails(BankDetails bankDetails)
        {
            var result = _websiteContent.EditBankDetails(bankDetails);
            return RedirectToAction("Index", "Home");
        }
    }
}
