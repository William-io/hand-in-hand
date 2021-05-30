using System.Collections;
using System.Collections.Generic;

namespace ContentContext
{
    public class CourseBook : Content
    {
        public CourseBook()
        {
            Modules = new List<Module>();
        }
        public string Reference {get; set;}
        public IList<Module> Modules { get; set; }

    }
    public class Module
    {
        public Module()
        {
            StudyProgression = new List<StudyProgression>();
        }
        public int Order { get; set; }  
        public string Title { get; set; }

        public IList<StudyProgression> StudyProgression { get; set; }

    }
    
    public class StudyProgression
    {
        public int Ordem { get; set; }
        public string Title { get; set; }   

    }
    
}
