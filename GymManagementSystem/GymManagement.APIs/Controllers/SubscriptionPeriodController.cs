using GymManagement.BusinessCore.Models;
using Microsoft.AspNetCore.Mvc;
using GymManagement.BusinessCore.Contracts.Repositories;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = clsSystemRoles.Admin)]
    public class SubscriptionPeriodController(IBaseRepository<SubscriptionPeriod, byte> _subscriptionPeriodRepo) : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<SubscriptionPeriod>> GetAllPeriods()
        {
            return Ok(_subscriptionPeriodRepo.GetAll());
        }

        [HttpGet("{id:int}")]
        public ActionResult<SubscriptionPeriod> GetAllPeriods(byte id)
        {
            var result = _subscriptionPeriodRepo.GetById(id);
            return result is null ? NotFound($"Period with id = {id} is not found") : Ok(result);
        }
    }
}
