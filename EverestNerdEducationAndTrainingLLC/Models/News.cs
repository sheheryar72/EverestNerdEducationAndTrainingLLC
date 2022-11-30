using System;

namespace EverestNerdEducationAndTrainingLLC.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Catagory { get; set; }
        public DateTime NewsDate { get; set; }
    }
}
