
namespace GymManagement.BusinessCore.Models

{
    public class Member : Person
    {
        public decimal? MemberWeight { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }

        public Member(int id,
                      string firstName,
                      string secondName,
                      string? thirdName,
                      string lastName,
                      string? nationalNumber,
                      string? phoneNumber,
                      string? email,
                      string? address,
                      DateTime? birthDate,
                      decimal? memberWeight,
                      bool isActive) : base(id,
                                            firstName,
                                            secondName,
                                            thirdName,
                                            lastName,
                                            nationalNumber,
                                            phoneNumber,
                                            birthDate,
                                            email,
                                            address)
        {
            MemberWeight = memberWeight;
            IsActive = isActive;
        }
        
        public Member(string firstName,
                      string secondName,
                      string? thirdName,
                      string lastName,
                      string? nationalNumber,
                      string? phoneNumber,
                      string? email,
                      string? address,
                      DateTime? birthDate,
                      decimal? memberWeight,
                      bool isActive) : base(default,
                                            firstName,
                                            secondName,
                                            thirdName,
                                            lastName,
                                            nationalNumber,
                                            phoneNumber,
                                            birthDate,
                                            email,
                                            address)
        {
            MemberWeight = memberWeight;
            IsActive = isActive;
        }
    }
}
