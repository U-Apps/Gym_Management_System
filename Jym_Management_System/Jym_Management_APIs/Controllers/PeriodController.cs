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

namespace Jym_Management_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = clsSystemRoles.User)]
    public class PeriodController : ControllerBase
    {
        private readonly IBaseServices<Period> _periodService;


        public PeriodController(IBaseServices<Period> periodService)
        {
            _periodService = periodService;
           
        }


        [HttpPost]
        [Route("")]

        public ActionResult CreatePeriod(CreatePeriodDTO createPeriodDTO)
        {
            var period = new Period();

            period.PeriodName = createPeriodDTO.PeriodName;
            period.StartTime = createPeriodDTO.StartTime;
            period.EndTime=createPeriodDTO.EndTime;
  
            _periodService.Add(period);
            return Ok();
        }

        [HttpPut]
        [Route("")]

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
        [Route("")]
        public ActionResult<IEnumerable<ReadPermssionDTO>> Get()
        {

            var periods = _periodService.GetAll().Select(period => period.AsDTO());

            return Ok(periods);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReadPeriodDTO> GetById(int id)
        {
            Period Period = _periodService.GetById(id);
            return Period is null ? NotFound() : Ok(Period.AsDTO());
        }

        [HttpDelete]
        [Route("{id}")]
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
