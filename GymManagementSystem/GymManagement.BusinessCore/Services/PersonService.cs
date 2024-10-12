//using GymManagement.BusinessCore.Contracts.Repositories;
//using GymManagement.BusinessCore.Contracts.Services;
//using GymManagement.BusinessCore.Models;
//using System.Linq.Expressions;

//namespace GymManagement.BusinessCore.Services
//{
//    public class PersonService :IBaseServices<Person>
//    {
//        protected readonly IBaseRepository<Person> _Repository;
//        public PersonService(IBaseRepository<Person> repository)
//        {
//            _Repository = repository;
//        }


//        public int Add(Person model)
//        {
//            _Repository.Add(model);
//            return model.Id;
//        }

//        public void AddRange(IEnumerable<Person> model)
//        {
//            _Repository.AddRange(model);
//        }

//        public void Delete(Person model)
//        {
//            _Repository.Delete(model);
//        }

//        public void DeleteById(int id)
//        {
//           //_Repository.DeleteById(c => c.Id == id);
//        }

//        public void DeleteRange(IEnumerable<Person> model)
//        {
//            _Repository.DeleteRange(model);
//        }

//        public Person Find(Expression<Func<Person, bool>>  predicate)
//        {
//            return _Repository.Find(predicate);
            
//        }

//        public IEnumerable<Person> FindAll(Func<Person, bool> predicate)
//        {
//            return _Repository.FindAll(predicate);
//        }

//        public IEnumerable<Person> GetAll()
//        {
//            return null;// _Repository.GetAll(c=>c.Member,c=>c.Employee,c=>c.User!);
//        }

//        public Person GetById(int id)
//        {
//            return _Repository.GetById(c => c.Id == id);
//        }

//        public void Update(Person model)
//        {
//            _Repository.Update(model);
//        }
        
//    }
//}
