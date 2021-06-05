using System.Collections.Generic;

namespace Hand.NotificationContext
{
    public abstract class Notifiable
    {
        //Onde a classe que outras classes vão herdar dela. 
        public List<Notification> Notifications { get; set; }

        //Metodos 
        public void Add(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddRange(IEnumerable<Notification> notification)
        {
            Notifications.AddRange(notification);
        }

    }
    
}