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
    public class SubscriptionPeriodController : ControllerBase
    {
        private readonly IBaseServices<SubscriptionPeriod> _subscriptionPeriodService;


        public SubscriptionPeriodController(IBaseServices<SubscriptionPeriod> subscriptionService)
        {
            _subscriptionPeriodService = subscriptionService;
           
        }


        [HttpPost]
        [Route("[action]")]

        public ActionResult CreateSubscriptionPeriod(CreateSubscriptionPeriodDTO createSubscriptionPeriodDTO)
        {
            var subscriptionPeriod = new SubscriptionPeriod();

            subscriptionPeriod.Name = createSubscriptionPeriodDTO.Name;
            subscriptionPeriod.Price = createSubscriptionPeriodDTO.Price;

            _subscriptionPeriodService.Add(subscriptionPeriod);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]

        public ActionResult UpdateSubscriptionPeriod(UpdateSubscriptionPeriodDTO updateSubscriptionPeriodDTO)
        {
            var existingSubscriptionPeriod = _subscriptionPeriodService.GetById(updateSubscriptionPeriodDTO.Id);
            if (existingSubscriptionPeriod == null)
                return NotFound();

            existingSubscriptionPeriod.Name = updateSubscriptionPeriodDTO.Name;
            existingSubscriptionPeriod.Price = updateSubscriptionPeriodDTO.Price;

            _subscriptionPeriodService.Update(existingSubscriptionPeriod);
            return Ok();
        }


        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<ReadSubscriptionPeriodDTO>> Get()
        {

            var subscriptionPeriod = _subscriptionPeriodService.GetAll().Select(subscriptionPeriod => subscriptionPeriod.AsDTO());

            return Ok(subscriptionPeriod);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public ActionResult<ReadSubscriptionPeriodDTO> GetById(int id)
        {
            SubscriptionPeriod subscriptionPeriod = _subscriptionPeriodService.GetById(id);
            return subscriptionPeriod is null ? NotFound() : Ok(subscriptionPeriod.AsDTO());
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public ActionResult Delete(int id)
        {
            SubscriptionPeriod subscriptionPeriod = _subscriptionPeriodService.GetById(id);

            if (subscriptionPeriod is null)
                return NotFound();

            _subscriptionPeriodService.DeleteById(subscriptionPeriod.Id);

            return Ok();
        }
    }
}
