using Hand.ContentContext.Enums;

namespace Hand.ContentContext
{
    public class StudyProgression //Progressão 
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationOnMinutes { get; set; }
        public EContentLevel Level { get; set; }

    }
}