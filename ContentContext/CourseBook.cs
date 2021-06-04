using System.Collections.Generic;
using Hand.ContentContext.Enums;

namespace Hand.ContentContext
{
    public class CourseBook : Content //Nivel 
    {
        public CourseBook(string title, string url)
        : base(title, url)
        {
            Modules = new List<Module>();
        }
        public string Reference {get; set;}
        public IList<Module> Modules { get; set; }
        public int DurationOnMinutes { get; set; }
        public EContentLevel Level { get; set; }
        

    }
}
