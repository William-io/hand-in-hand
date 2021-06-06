using Hand.SharedContext;

namespace Hand.SubscriptionContext
{
    public class Student : ClassBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }  
    }
}