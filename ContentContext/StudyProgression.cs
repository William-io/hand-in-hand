using Hand.ContentContext.Enums;
using Hand.SharedContext;

namespace Hand.ContentContext
{
    public class StudyProgression : ClassBase//Progressão 
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationOnMinutes { get; set; }
        public EContentLevel Level { get; set; }

    }
}