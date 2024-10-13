using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GymManagement.APIs.Authentication;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.Models;
using GymManagement.APIs.DTOs;
using GymManagement.BusinessCore.Contracts.Repositories;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = clsSystemRoles.Admin)]
    public class ExerciseTypeController(IExerciseTypeRepo _exerciseTypeRepo) : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ExerciseType>> GetAllExerciseTypes()
        {
            return Ok(_exerciseTypeRepo.GetTypes());
        }

        [HttpGet("{id:int}")]
        public ActionResult<ExerciseType> GetExerciseTypeById(int id)
        {
            var result = _exerciseTypeRepo.GetTypeById(id);
            return result is null ? NotFound($"Exercise type with id = {id} not found") : Ok(result);
        }
    }
}
