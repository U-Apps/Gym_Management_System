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
    }
}
