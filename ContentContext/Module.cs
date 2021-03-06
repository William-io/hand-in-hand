using System.Collections.Generic;
using Hand.SharedContext;

namespace Hand.ContentContext
{
   public class Module : ClassBase
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