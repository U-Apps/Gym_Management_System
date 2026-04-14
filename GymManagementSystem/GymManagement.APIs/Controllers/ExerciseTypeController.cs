using Microsoft.AspNetCore.Mvc;
using GymManagement.BusinessCore.Models;
using GymManagement.BusinessCore.Contracts.Repositories;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = clsSystemRoles.Admin)]
    public class ExerciseTypeController(IBaseRepository<ExerciseType, byte> _exerciseTypeRepo) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExerciseType>>> GetAllExerciseTypes()
        {
            return Ok(await _exerciseTypeRepo.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ExerciseType>> GetExerciseTypeByIdAsync(byte id)
        {
            var result = await _exerciseTypeRepo.GetByIdAsync(id);
            return result is null ? NotFound($"Exercise type with id = {id} not found") : Ok(result);
        }
    }
}
