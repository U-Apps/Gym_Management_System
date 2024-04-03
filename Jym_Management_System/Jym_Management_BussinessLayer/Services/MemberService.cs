using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class MemberService : IBaseServices<Member>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(Member module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Member> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(Member module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<Member> modules)
        {
            throw new NotImplementedException();
        }

        public Member Find(Func<Member, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> FindAll(Func<Member, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetAll()
        {
            throw new NotImplementedException();
        }

        public Member GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Member module)
        {
            throw new NotImplementedException();
        }
    }
}
