using Jym_Management_APIs.DTO_modules;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jym_Management_BussinessLayer.Services.Base;
using System.Xml.Linq;

namespace Jym_Management_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobHistoryController : ControllerBase
    {
        private readonly IBaseServices<JobHistory> _jobHistoryService;


        public JobHistoryController(IBaseServices<JobHistory> jobHistoryService)
        {
            _jobHistoryService = jobHistoryService;
           
        }


        [HttpPost]
        [Route("")]

        public ActionResult CreateJobHistory(CreateJobHistoryDTO createJobHistoryDTO)
        {
            var jobHistory = new JobHistory();

            jobHistory.StartDate = createJobHistoryDTO.StartDate;
            jobHistory.EndDate = createJobHistoryDTO.EndDate;
            jobHistory.EmpoyeeId = createJobHistoryDTO.EmpoyeeId;
            jobHistory.JobId = createJobHistoryDTO.JobId;


            _jobHistoryService.Add(jobHistory);
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public ActionResult UpdateJobHistory(UpdateJobHistoryDTO updateJobHistoryDTO)
        {
            var existingJobHistory = _jobHistoryService.GetById(updateJobHistoryDTO.Id);
            if (existingJobHistory == null)
                return NotFound();

            existingJobHistory.StartDate = updateJobHistoryDTO.StartDate;
            existingJobHistory.EndDate = updateJobHistoryDTO.EndDate;
            existingJobHistory.EmpoyeeId = updateJobHistoryDTO.EmpoyeeId;
            existingJobHistory.JobId = updateJobHistoryDTO.JobId;

            _jobHistoryService.Update(existingJobHistory);
            return Ok();
        }


        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<ReadJobDTO>> Get()
        {

            var jobHistories = _jobHistoryService.GetAll().Select(jobHistory => jobHistory.AsDTO());

            return Ok(jobHistories);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReadJobHistoryDTO> GetById(int id)
        {
            JobHistory jobHistory = _jobHistoryService.GetById(id);
            return jobHistory is null ? NotFound() : Ok(jobHistory.AsDTO());
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            JobHistory jobHistory = _jobHistoryService.GetById(id);

            if (jobHistory is null)
                return NotFound();

            _jobHistoryService.DeleteById(jobHistory.Id);

            return Ok();
        }
    }
}
