using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EverestNerdEducationAndTrainingLLC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string ContactNo { get; set; }
        public string Password { get; set; }
        public string Interestofstudy { get; set; }
        public string Grade { get; set; }

    }
}
