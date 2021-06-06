using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Hand.SharedContext;

namespace Hand.SubscriptionContext
{
    public class Student : ClassBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}