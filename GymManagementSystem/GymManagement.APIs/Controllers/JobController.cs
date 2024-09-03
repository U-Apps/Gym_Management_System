﻿using Jym_Management_APIs.DTO_modules;
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
    [Authorize(Roles = clsSystemRoles.Admin)]
    public class JobController : ControllerBase
    {
        private readonly IBaseServices<Job> _jobService;


        public JobController(IBaseServices<Job> jobService)
        {
            _jobService = jobService;
           
        }


        [HttpPost]
        [Route("[action]")]

        public ActionResult CreateJob(CreateJobDTO createJobDTO)
        {
            var job = new Job();

            job.JobTitle = createJobDTO.JobTitle;
  
            _jobService.Add(job);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]

        public ActionResult UpdateJob(UpdateJobDTO updateJobDTO)
        {
            var existingJob = _jobService.GetById(updateJobDTO.JobId);
            if (existingJob == null)
                return NotFound();

            existingJob.JobTitle = updateJobDTO.JobTitle;

            _jobService.Update(existingJob);
            return Ok();
        }


        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<ReadJobDTO>> Get()
        {

            var jobs = _jobService.GetAll().Select(job => job.AsDTO());

            return Ok(jobs);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public ActionResult<ReadJobDTO> GetById(int id)
        {
            Job job = _jobService.GetById(id);
            return job is null ? NotFound() : Ok(job.AsDTO());
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public ActionResult Delete(int id)
        {
            Job job = _jobService.GetById(id);

            if (job is null)
                return NotFound();

            _jobService.DeleteById(job.JobId);

            return Ok();
        }
    }
}
