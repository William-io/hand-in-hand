using System.Collections.Generic;

namespace Hand.ContentContext
{
    public class Author : Content
    {
        public Author()
        {
            Items = new List<AuthorItem>();
        }
          
        public IList<AuthorItem> Items {get; set;}
        public int TotalAuthor => Items.Count;
        //Expression body
    }

    
}