using System;

namespace Hand.ContentContext
{
    /*Classe base para herança*/
   public abstract class Content : ClassBase
   {
      public Content(string title, string url)
      {
         Title = title;
         Url = url;
        
      }
      
      public string Title { get; set; }      
      public string Url { get; set; }
   
   }
   
   
    
}
