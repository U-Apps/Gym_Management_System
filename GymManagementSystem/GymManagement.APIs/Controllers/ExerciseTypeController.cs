using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GymManagement.APIs.Authentication;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.Models;
using GymManagement.APIs.DTOs;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = clsSystemRoles.Admin)]
    public class ExerciseTypeController : ControllerBase
    {
        private readonly IBaseServices<ExerciseType> _exerciseTypeService;


        public ExerciseTypeController(IBaseServices<ExerciseType> exerciseTypeService)
        {
            _exerciseTypeService = exerciseTypeService;
           
        }


        [HttpPost]
        [Route("[action]")]

        public ActionResult CreateExerciseType(CreateExerciseTypeDTO createExerciseTypeDTO)
        {
            var exerciseType = new ExerciseType();

            exerciseType.Name = createExerciseTypeDTO.Name;
  
            _exerciseTypeService.Add(exerciseType);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]

        public ActionResult UpdateExerciseType(UpdateExerciseTypeDTO updateExerciseTypeDTO)
        {
            var existingExerciseType = _exerciseTypeService.GetById(updateExerciseTypeDTO.ExerciseTypeId);
            if (existingExerciseType == null)
                return NotFound();

            existingExerciseType.Name = updateExerciseTypeDTO.Name;

            _exerciseTypeService.Update(existingExerciseType);
            return Ok();
        }


        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<ReadExerciseTypeDTO>> Get()
        {

            var exerciseTypes = _exerciseTypeService.GetAll().Select(exerciseType => exerciseType.AsDTO());

            return Ok(exerciseTypes);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public ActionResult<ReadExerciseTypeDTO> GetById(int id)
        {
            ExerciseType exerciseType = _exerciseTypeService.GetById(id);
            return exerciseType is null ? NotFound() : Ok(exerciseType.AsDTO());
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public ActionResult Delete(int id)
        {
            ExerciseType exerciseType = _exerciseTypeService.GetById(id);

            if (exerciseType is null)
                return NotFound();

            _exerciseTypeService.DeleteById(exerciseType.ExerciseTypeId);

            return Ok();
        }
    }
}
