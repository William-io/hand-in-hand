namespace Hand.ContentContext
{
   public class AuthorItem
    {
        public AuthorItem(int order, string title, string description, CourseBook courseBook)
        {
            Order = order;
            Title = title;
            Description = description;
            this.courseBook = courseBook;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseBook courseBook { get; set; }
    }
    
}