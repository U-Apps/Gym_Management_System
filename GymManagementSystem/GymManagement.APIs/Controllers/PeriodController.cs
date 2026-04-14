using GymManagement.BusinessCore.Models;
using Microsoft.AspNetCore.Mvc;
using GymManagement.BusinessCore.Contracts.Repositories;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = clsSystemRoles.Admin)]
    public class PeriodController(IBaseRepository<Period, byte> _PeriodRepo) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPeriods()
        {
            return Ok(_PeriodRepo.GetAll());
        }

        [HttpGet("{id:int}")]
        public ActionResult<Period> GetPeriods(byte id)
        {
            var result = _PeriodRepo.GetById(id);
            return result is null? NotFound($"Period with id = {id} not found") : Ok(result);
        }
    }
}
