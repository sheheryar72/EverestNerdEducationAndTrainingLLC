using System.Collections.Generic;

namespace EverestNerdEducationAndTrainingLLC.Models
{
    public class HomePageContent
    {
        public List<ClientFeedBack> clientFeedBacks { get; set; }
        public List<Course> courses { get; set; }
        public Footer footer { get; set; }
        public HomePageContentDetails homePageContentDetails { get; set; }
    }
}
