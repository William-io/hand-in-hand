using Hand.NotificationContext;

namespace Hand.ContentContext
{
   public class AuthorItem : ClassBase
    {
        public AuthorItem(
            int order,
            string title, 
            string description, 
            CourseBook courseBook)
        {

            if (courseBook == null)
                AddNotification(new Notification("Course", "Curso inválido"));
            
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