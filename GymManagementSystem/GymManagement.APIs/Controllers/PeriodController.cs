using Jym_Management_APIs.DTO_modules;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jym_Management_BussinessLayer.Services.Base;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;
using Jym_Management_APIs.Authentication;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = clsSystemRoles.Admin)]
    public class PeriodController : ControllerBase
    {
        private readonly IBaseServices<Period> _periodService;


        public PeriodController(IBaseServices<Period> periodService)
        {
            _periodService = periodService;
           
        }


        [HttpPost]
        [Route("[action]")]

        public ActionResult CreatePeriod(CreatePeriodDTO createPeriodDTO)
        {
            var period = new Period();

            period.PeriodName = createPeriodDTO.PeriodName;
            period.StartTime = createPeriodDTO.StartTime.TimeOfDay;
            period.EndTime=createPeriodDTO.EndTime.TimeOfDay;
  
            _periodService.Add(period);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]

        public ActionResult UpdatePeriod(UpdatePeriodDTO updatePeriodDTO)
        {
            var existingPeriod = _periodService.GetById(updatePeriodDTO.PeriodId);
            if (existingPeriod == null)
                return NotFound();

            existingPeriod.PeriodName = updatePeriodDTO.PeriodName;
            existingPeriod.StartTime = updatePeriodDTO.StartTime;
            existingPeriod.EndTime = updatePeriodDTO.EndTime;

            _periodService.Update(existingPeriod);
            return Ok();
        }


        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<ReadPermssionDTO>> Get()
        {

            var periods = _periodService.GetAll().Select(period => period.AsDTO());

            return Ok(periods);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public ActionResult<ReadPeriodDTO> GetById(int id)
        {
            Period Period = _periodService.GetById(id);
            return Period is null ? NotFound() : Ok(Period.AsDTO());
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public ActionResult Delete(int id)
        {
            Period period = _periodService.GetById(id);

            if (period is null)
                return NotFound();

            _periodService.DeleteById(period.PeriodId);

            return Ok();
        }
    }
}
