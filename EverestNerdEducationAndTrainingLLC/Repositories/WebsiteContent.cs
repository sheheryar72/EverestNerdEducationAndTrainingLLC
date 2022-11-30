using Dapper;
using EO.WebBrowser.DOM;
using EverestNerdEducationAndTrainingLLC.IRepositories;
using EverestNerdEducationAndTrainingLLC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;

namespace EverestNerdEducationAndTrainingLLC.Repositories
{
    public class WebsiteContent : IWebsiteContent
    {
        private readonly IDbConnection conn;
        public WebsiteContent(IDbConnection dbConnection)
        {
            conn = dbConnection;
        }

        public AboutUs GetAboutUs()
        {
            Serilog.Log.Information("GetAboutUs Method Called");
            try
            {
                string query = "select * from AboutUs";
                var _parameter = new Dictionary<string, object>();
                AboutUs result = conn.Query<AboutUs>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Course> GetAllCourses()
        {
            Serilog.Log.Information("GetAllCourses Method Called");
            try
            {
                string query = "select * from Courses;";
                var _parameter = new Dictionary<string, object>();
                List<Course> result = conn.Query<Course>(query, param: _parameter, commandType: CommandType.Text).ToList();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void LocalStorageStoreData()
        {
            //Window.localStorage.setItem(“CustName”, Document.getElementById(“txtCustomer”).value);
            //window.localStorage.setItem(“CustAddr”, document.getElementById(“txtCustAddr”).value);
        }

        public List<Teacher> GetAllTeacher()
        {
            Serilog.Log.Information("GetAllTeacher Method Called");
            try
            {
                string query = "select * from Teacher;";
                var _parameter = new Dictionary<string, object>();
                List<Teacher> result = conn.Query<Teacher>(query, param: _parameter, commandType: CommandType.Text).ToList();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<News> GetAllNews()
        {
            Serilog.Log.Information("GetAllTeacher Method Called");
            try
            {
                string query = "select * from News;";
                var _parameter = new Dictionary<string, object>();
                List<News> result = conn.Query<News>(query, param: _parameter, commandType: CommandType.Text).ToList();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int EditNewsInDB(News news)
        {
            string query = "Update News Set Title = @Title, Description = @Description, ImagePath = @ImagePath, Catagory = @Catagory, Name = @Name, NewsDate = @NewsDate Where Id = @Id Select @Id";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@Id", news.Id);
            _parameter.Add("@Title", news.Title);
            _parameter.Add("@Description", news.Description);
            _parameter.Add("@ImagePath", news.ImagePath);
            _parameter.Add("@Catagory", news.Catagory);
            _parameter.Add("@Name", news.Name);
            _parameter.Add("@NewsDate", news.NewsDate);
            var result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
        public int InsertNewsInDB(News news)
        {
            string query = "Insert into News (Title, Description, ImagePath, Catagory, Name, NewsDate) Values (@Title, @Description, @ImagePath, @Catagory, @Name, @NewsDate) Select Scope_Identity()";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@Title", news.Title);
            _parameter.Add("@Description", news.Description);
            _parameter.Add("@ImagePath", news.ImagePath);
            _parameter.Add("@Catagory", news.Catagory);
            _parameter.Add("@Name", news.Name);
            _parameter.Add("@NewsDate", news.NewsDate);
            var result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
        public News GetNewsById(int Id)
        {
            Serilog.Log.Information("GetCoursesById Method Called");
            try
            {
                string query = "select * from News where Id = @Id;";
                var _parameter = new Dictionary<string, object>();
                _parameter.Add("@Id", Id);
                News result = conn.Query<News>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int DeleteNews(int Id)
        {
            string query = "Delete from News where Id = @Id Select @Id";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@Id", Id);
            var result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
        public Course GetCoursesById(int Id)
        {
            Serilog.Log.Information("GetCoursesById Method Called");
            try
            {
                string query = "select * from Courses where Id = @Id;";
                var _parameter = new Dictionary<string, object>();
                _parameter.Add("@Id", Id);
                Course result = conn.Query<Course>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Footer GetFooter()
        {
            Serilog.Log.Information("GetFooter Method Called");
            try
            {
                string query = "select * from Footer";
                var _parameter = new Dictionary<string, object>();
                Footer result = conn.Query<Footer>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int UpdateAboutUs(AboutUs aboutUs)
        {
            string query = "Update AboutUs Set Title = @Title, Discription = @Discription, WhyChooseUs = @WhyChooseUs, OurMission = @OurMission, OurVission = @OurVission, StudentsEnrolled = @StudentsEnrolled, CoursesUploaded = @CoursesUploaded, PeopleCertifie = @PeopleCertifie, GlobalTeachers = @GlobalTeachers Where Id = @Id Select @Id";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@Id", aboutUs.Id);
            _parameter.Add("@Title", aboutUs.Title);
            _parameter.Add("@Discription", aboutUs.Discription);
            _parameter.Add("@WhyChooseUs", aboutUs.WhyChooseUs);
            _parameter.Add("@OurMission", aboutUs.OurMission);
            _parameter.Add("@OurVission", aboutUs.OurVission);
            _parameter.Add("@StudentsEnrolled", aboutUs.StudentsEnrolled);
            _parameter.Add("@CoursesUploaded", aboutUs.CoursesUploaded);
            _parameter.Add("@PeopleCertifie", aboutUs.PeopleCertifie);
            _parameter.Add("@GlobalTeachers", aboutUs.GlobalTeachers);
            var result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
        public int EditFooterInDB(Footer footer)
        {
            string query = "Update Footer Set Address = @Address, Phone = @Phone, Email = @Email, Facebook = @Facebook, Twitter = @Twitter, Instagram = @Instagram, Google = @Google, Discription = @Discription Where Id = @Id Select @Id";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@Id", footer.Id);
            _parameter.Add("@Address", footer.Address);
            _parameter.Add("@Phone", footer.Phone);
            _parameter.Add("@Email", footer.Email);
            _parameter.Add("@Facebook", footer.Facebook);
            _parameter.Add("@Twitter", footer.Twitter);
            _parameter.Add("@Instagram", footer.Instagram);
            _parameter.Add("@Google", footer.Google);
            _parameter.Add("@Discription", footer.Discription);
            var result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
        public int EditCourseInDB(Course course)
        {
            string query = "Update Courses Set Name = @Name, Teacher = @Teacher, Discription = @Discription Where Id = @Id Select @Id";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@Id", course.Id);
            _parameter.Add("@Name", course.Name);
            _parameter.Add("@Teacher", course.Teacher);
            _parameter.Add("@Discription", course.Discription);
            var result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
        public int EditTeacherInDB(Teacher teacher)
        {
            string query = "Update Teacher Set Name = @Name, Profession = @Profession, Discription = @Discription Where Id = @Id Select @Id";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@Id", teacher.Id);
            _parameter.Add("@Name", teacher.Name);
            _parameter.Add("@Profession", teacher.Profession);
            _parameter.Add("@Discription", teacher.Discription);
            var result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
        public Teacher GetTeacherById(int Id)
        {
            Serilog.Log.Information("GetCoursesById Method Called");
            try
            {
                string query = "select * from Teacher where Id = @Id;";
                var _parameter = new Dictionary<string, object>();
                _parameter.Add("@Id", Id);
                Teacher result = conn.Query<Teacher>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public BankDetails GetBankDetails()
        {
            try
            {
                string query = "select * from BankDetails";
                BankDetails result = conn.Query<BankDetails>(query, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int? EditBankDetails(BankDetails bankDetails)
        {
            try
            {
                string query = "Update BankDetails Set AccountNo = @AccountNo, BankName = @BankName, PhoneNo = @PhoneNo, Email = @Email, Country = @Country, City = @City where Id = @Id Select @Id";
                var _parameter = new Dictionary<string, object>();
                _parameter.Add("@Id", bankDetails.Id);
                _parameter.Add("@AccountNO", bankDetails.AccountNO);
                _parameter.Add("@BankName", bankDetails.BankName);
                _parameter.Add("@PhoneNo", bankDetails.PhoneNo);
                _parameter.Add("@Email", bankDetails.Email);
                _parameter.Add("@Country", bankDetails.Country);
                _parameter.Add("@City", bankDetails.City);
                int result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public HomePageContentDetails GetAllHomePageContentDetails()
        {
            Serilog.Log.Information("GetAllTeacher Method Called");
            try
            {
                string query = "select * from HomePageContentDetails;";
                HomePageContentDetails result = conn.Query<HomePageContentDetails>(query, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int UpdateHomePageContentDetails(HomePageContentDetails home)
        {
            string query = "Update HomePageContentDetails Set BannerTitle = @BannerTitle, Title = @Title, Description  = @Description, WhyUsBox1 = @WhyUsBox1, WhyUsBox2 = @WhyUsBox2, WhyUsBox3 = @WhyUsBox3, RegisterWithUs = @RegisterWithUs, ApplyFor = @ApplyFor, LatestNewsTitle = @LatestNewsTitle, LatestNewsDescription = @LatestNewsDescription, LatestNewsTitle1 = @LatestNewsTitle1, LatestNewsDescription1 = @LatestNewsDescription1, LatestNewsTitle2 = @LatestNewsTitle2, LatestNewsDescription2 = @LatestNewsDescription2 ,LatestNewsTitle3 = @LatestNewsTitle3, LatestNewsDescription3 = @LatestNewsDescription3 Where Id = @Id Select @Id";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@Id", home.Id);
            _parameter.Add("@BannerTitle", home.BannerTitle);
            _parameter.Add("@Title", home.Title);
            _parameter.Add("@Description", home.Description);
            _parameter.Add("@WhyUsBox1", home.WhyUsBox1);
            _parameter.Add("@WhyUsBox2", home.WhyUsBox2);
            _parameter.Add("@WhyUsBox3", home.WhyUsBox3);
            _parameter.Add("@RegisterWithUs", home.RegisterWithUs);
            _parameter.Add("@ApplyFor", home.ApplyFor);
            _parameter.Add("@LatestNewsTitle", home.LatestNewsTitle);
            _parameter.Add("@LatestNewsTitle1", home.LatestNewsTitle1);
            _parameter.Add("@LatestNewsTitle2", home.LatestNewsTitle2);
            _parameter.Add("@LatestNewsTitle3", home.LatestNewsTitle3);
            _parameter.Add("@LatestNewsDescription", home.LatestNewsDescription);
            _parameter.Add("@LatestNewsDescription1", home.LatestNewsDescription1);
            _parameter.Add("@LatestNewsDescription2", home.LatestNewsDescription2);
            _parameter.Add("@LatestNewsDescription3", home.LatestNewsDescription3);
            var result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
    }
}
