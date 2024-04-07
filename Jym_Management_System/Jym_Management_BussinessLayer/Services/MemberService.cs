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
       
        public void Add(Member module)
        {
            IBaseRepository<TbMember> repo = new BaseRepository<TbMember>(new AppDbContext());
            var tbMember = Mapping.Mapper.Map<TbMember>(module);
            repo.Add(tbMember);
           repo.SaveChanges();
            repo.Dispose();
        }

        public void AddRange(IEnumerable<Member> module)
        {
            IBaseRepository<TbMember> repo = new BaseRepository<TbMember>(new AppDbContext());
            var tbMember = Mapping.Mapper.Map<IEnumerable<TbMember>>(module);
            repo.AddRange(tbMember);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void Delete(Member module)
        {
            IBaseRepository<TbMember> repo = new BaseRepository<TbMember>(new AppDbContext());
            var tbMember = Mapping.Mapper.Map<TbMember>(module);
            repo.Delete(tbMember);
            repo.SaveChanges();
            repo.Dispose();
            
        }
        public void DeleteById(int id)
        {
            IBaseRepository<TbMember> repo = new BaseRepository<TbMember>(new AppDbContext());
            repo.DeleteById(c => c.MemberId == id);
            repo.SaveChanges();
            repo.Dispose();


        }

        public void DeleteRange(IEnumerable<Member> modules)
        {
            IBaseRepository<TbMember> repo = new BaseRepository<TbMember>(new AppDbContext());
            var tbMember = Mapping.Mapper.Map<IEnumerable<TbMember>>(modules);
            repo.DeleteRange(tbMember);
             repo.SaveChanges();
            repo.Dispose();

        }

        public Member Find(Func<Member, bool> predicate)
        {
            IBaseRepository<TbMember> repo = new BaseRepository<TbMember>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbMember, bool>>(predicate);
            return Mapping.Mapper.Map<Member>(repo.Find(exp));
        }

        public IEnumerable<Member> FindAll(Func<Member, bool> predicate)
        {
            IBaseRepository<TbMember> repo = new BaseRepository<TbMember>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbMember, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Member>>(repo.FindAll(exp));
        }

        public IEnumerable<Member> GetAll()
        {
            IBaseRepository<TbMember> repo = new BaseRepository<TbMember>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<Member>>(repo.GetAll());
        }

        public Member GetById(int id)
        {
            IBaseRepository<TbMember> repo = new BaseRepository<TbMember>(new AppDbContext());
            return Mapping.Mapper.Map<Member>(repo.GetById(c => c.MemberId == id));

        }

        public void Update(Member module)
        {
            IBaseRepository<TbMember> repo = new BaseRepository<TbMember>(new AppDbContext());
            TbMember tbMember = Mapping.Mapper.Map<TbMember>(module);
            repo.Update(tbMember);
            repo.SaveChanges();
            repo.Dispose();
        }

    }
}
