using System.Collections.Generic;

namespace Hand.ContentContext
{
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
    
}