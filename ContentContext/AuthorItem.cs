namespace Hand.ContentContext
{
   public class AuthorItem
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseBook courseBook { get; set; }
    }
    
}