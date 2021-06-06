using System.Collections.Generic;
using System.Linq;

namespace Hand.NotificationContext
{
    public abstract class Notifiable
    {
        //Onde a classe que outras classes vão herdar dela. 
        public List<Notification> Notifications { get; set; }

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }

        //Metodos 
        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notification)
        {
            Notifications.AddRange(notification);
        }

        public bool IsInvalid => Notifications.Any(); //Se tiver erro o objeto vai está errado

    }
    
}