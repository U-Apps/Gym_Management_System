using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.Models;
using System.Linq.Expressions;

namespace GymManagement.BusinessCore.Services
{
    public class MemberService : IBaseServices<Member>
    {
        protected readonly IBaseRepository<Member> _Repository;
        public MemberService(IBaseRepository<Member> repository)
        {
            _Repository = repository;
        }
        public int Add(Member model)
        {
            _Repository.Add(model);
            return model.MemberId;
        }

        public void AddRange(IEnumerable<Member> model)
        {
            _Repository.AddRange(model);
        }

        public void Delete(Member model)
        {
            _Repository.Delete(model);            
        }
        public void DeleteById(int id)
        {
            _Repository.DeleteById(c => c.MemberId == id);
        }

        public void DeleteRange(IEnumerable<Member> model)
        {
            _Repository.DeleteRange(model);
        }

        public Member Find(Expression<Func<Member, bool>> predicate)
        {
            return _Repository.Find(predicate);
        }

        public IEnumerable<Member> FindAll(Func<Member, bool> predicate)
        {
            return _Repository.FindAll(predicate);
        }

        public IEnumerable<Member> GetAll()
        {
            return _Repository.GetAll(p=> p.Person);
        }

        public Member GetById(int id)
        {
            return _Repository.GetById(c => c.MemberId == id,p=>p.Person);

        }

        public void Update(Member model)
        {
            _Repository.Update(model);
        }

    }
}
