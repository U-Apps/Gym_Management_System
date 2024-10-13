using GymManagement.APIs.DTOs;
using GymManagement.BusinessCore.Models;
using Microsoft.AspNetCore.Mvc;
using GymManagement.BusinessCore.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using GymManagement.APIs.Authentication;
using GymManagement.BusinessCore.Contracts.Repositories;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = clsSystemRoles.Admin)]
    public class SubscriptionPeriodController(ISubscriptionPeriodRepo _subscriptionPeriodRepo) : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<SubscriptionPeriod>> GetAllPeriods()
        {
            return Ok(_subscriptionPeriodRepo.GetPeriods());
        }

        [HttpGet("{id:int}")]
        public ActionResult<SubscriptionPeriod> GetAllPeriods(int id)
        {
            var result = _subscriptionPeriodRepo.GetPeriodById(id);
            return result is null ? NotFound($"Period with id = {id} is not found") : Ok(result);
        }
    }
}
