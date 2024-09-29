
namespace GymManagement.BusinessCore.Models

{
    public class Member : Person
    {
        public decimal? MemberWeight { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
