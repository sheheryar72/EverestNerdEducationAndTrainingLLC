using EverestNerdEducationAndTrainingLLC.Models;
using System.Collections.Generic;

namespace EverestNerdEducationAndTrainingLLC.IRepositories
{
    public interface IWebsiteContent
    {
        List<Course> GetAllCourses();
        Course GetCoursesById(int Id);
        List<Teacher> GetAllTeacher();
        List<News> GetAllNews();
        int EditNewsInDB(News news);
        int DeleteNews(int Id);
        int InsertNewsInDB(News news);
        News GetNewsById(int Id);
        AboutUs GetAboutUs();
        int UpdateAboutUs(AboutUs aboutUs);
        Footer GetFooter();
        int EditFooterInDB(Footer footer);
        int EditCourseInDB(Course course);
        int EditTeacherInDB(Teacher teacher);
        Teacher GetTeacherById(int Id);
        BankDetails GetBankDetails();
        int? EditBankDetails(BankDetails bankDetails);
        HomePageContentDetails GetAllHomePageContentDetails();
        int UpdateHomePageContentDetails(HomePageContentDetails home);
    }
}
