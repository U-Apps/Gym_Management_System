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
    public class PeriodController(IPeriodRepo _PeriodRepo) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPeriods()
        {
            return Ok(_PeriodRepo.GetPeriods());
        }

        [HttpGet("{id:int}")]
        public ActionResult<Period> GetPeriods(int id)
        {
            var result = _PeriodRepo.GetPeriodById(id);
            return result is null? NotFound($"Period with id = {id} not found") : Ok(result);
        }
    }
}
