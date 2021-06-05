using System;
using Hand.NotificationContext;

namespace Hand.ContentContext
{
    public abstract class ClassBase : Notifiable
    {
        public ClassBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
    
}