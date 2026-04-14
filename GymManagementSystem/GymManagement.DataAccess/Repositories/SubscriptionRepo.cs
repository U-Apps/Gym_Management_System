using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Models;
using GymManagement.DataAccess.Data;

namespace GymManagement.DataAccess.Repositories
{
    public class SubscriptionRepo(AppDbContext _appDbContext) : ISubscriptionRepo
    {
        
        public void AddNewSubscription(Subscription subscription)
        {
            _appDbContext.Set<Subscription>().Add(subscription);
            _appDbContext.SaveChanges();
        }
    }
}
