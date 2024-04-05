using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class MemberService : IBaseServices<Member>
    {
        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());
        public void Add(Member module)
        {
            var tbMember = Mapping.Mapper.Map<TbMember>(module);
            _unit.Members.Add(tbMember);
            if (_unit.Complete() == 0)
                return;
        }

        public void AddRange(IEnumerable<Member> module)
        {
            var tbMember = Mapping.Mapper.Map<IEnumerable<TbJob>>(module);
            _unit.Jobs.AddRange(tbMember);
            if (_unit.Complete() == 0)
                return;
        }

        public void Delete(Member module)
        {
            var tbMember = Mapping.Mapper.Map<TbMember>(module);
            _unit.Members.Delete(tbMember);
            if (_unit.Complete() == 0)
                return;
        }
        public void DeleteById(int id)
        {
            _unit.Members.DeleteById(id);
            if (_unit.Complete() == 0)
                return;

        }

        public void DeleteRange(IEnumerable<Member> modules)
        {
            var tbMember = Mapping.Mapper.Map<IEnumerable<TbMember>>(modules);
            _unit.Members.DeleteRange(tbMember);
            if (_unit.Complete() == 0)
                return;

        }

        public Member Find(Func<Member, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbMember, bool>>(predicate);
            return Mapping.Mapper.Map<Member>(_unit.Members.Find(exp));
        }

        public IEnumerable<Member> FindAll(Func<Member, bool> predicate)
        {

            var exp = Mapping.Mapper.Map<Func<TbMember, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Member>>(_unit.Members.FindAll(exp));
        }

        public IEnumerable<Member> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<Member>>(_unit.Members.GetAll());
        }

        public Member GetById(int id)
        {

            return Mapping.Mapper.Map<Member>(_unit.Members.GetById(id));

        }

        public void Update(Member module)
        {

            TbMember tbMember = Mapping.Mapper.Map<TbMember>(module);
            _unit.Members.Update(tbMember);
            if (_unit.Complete() == 0)
                return;
        }

    }
}
