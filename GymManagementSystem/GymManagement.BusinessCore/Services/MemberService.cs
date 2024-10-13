using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.DTOs;
using GymManagement.BusinessCore.DTOs.Mappers;
using GymManagement.BusinessCore.Models;
using System.Linq.Expressions;

namespace GymManagement.BusinessCore.Services
{
    public class MemberService(IMemberRepo _memberRepository,
                               ISubscriptionService _subscriptionService,
                               ISubscriptionPeriodRepo _subscriptionPeriodRepo)
                               : IMemberService
    {
        
        public MemberResponse AddNewMember(Member member, Subscription subscriptionInfo)
        {
            // Manipulating Member
            member.RegisterationDate = DateTime.Now;
            member.IsActive = true;
            _memberRepository.AddNewMember(member);

            // Adding new subscription for the member
            subscriptionInfo.MemberId = member.Id;
            _subscriptionService.AddNewSubscription(subscriptionInfo);
            return member.ToResponse();
        }

        public IEnumerable<MemberResponse> GetAllMembers()
        {
            return _memberRepository.GetMembers().Select(m => m.ToResponse());
        }

        public MemberResponse GetMemberById(int id)
        {
            return _memberRepository.GetMemberById(id)?.ToResponse();
        }

        public bool updateMember(int id, UpdateMemberDTO memberInfo)
        {
            var ExsistMember = _memberRepository.GetMemberById(id, track: true);

            if (ExsistMember == null)
                return false;

            memberInfo.MapUpdatedPropertiesToMember(ref ExsistMember);

            _memberRepository.UpdateMember(ExsistMember);

            return true;
        }

        //public void AddRange(IEnumerable<Member> model)
        //{
        //    _memberRepository.AddRange(model);
        //}

        //public void Delete(Member model)
        //{
        //    _memberRepository.Delete(model);            
        //}
        //public void DeleteById(int id)
        //{
        //    _memberRepository.DeleteById(c => c.Id == id);
        //}

        //public void DeleteRange(IEnumerable<Member> model)
        //{
        //    _memberRepository.DeleteRange(model);
        //}

        //public Member Find(Expression<Func<Member, bool>> predicate)
        //{
        //    return _memberRepository.Find(predicate);
        //}

        //public IEnumerable<Member> FindAll(Func<Member, bool> predicate)
        //{
        //    return _memberRepository.FindAll(predicate);
        //}

        //public IEnumerable<Member> GetAll()
        //{
        //    return _memberRepository.GetAll();
        //}



        //public void Update(Member model)
        //{
        //    _memberRepository.Update(model);
        //}

    }
}
