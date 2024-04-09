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
    public class SubscriptionController : ControllerBase
    {
        private readonly IBaseServices<Subscription> _subscriptionService;


        public SubscriptionController(IBaseServices<Subscription> subscriptionService)
        {
            _subscriptionService = subscriptionService;
           
        }


        [HttpPost]
        [Route("")]

        public ActionResult CreateSubscription(CreateSubscriptionDTO createSubscriptionDTO)
        {
            var subscription = new Subscription();

            subscription.MemberId = createSubscriptionDTO.MemberId;
            subscription.PeriodId = createSubscriptionDTO.PeriodId;
            subscription.CoachId = createSubscriptionDTO.CoachId;
            subscription.CreatedByReceptionistId = createSubscriptionDTO.CreatedByReceptionistId;
            subscription.ExcerciseTypeId = createSubscriptionDTO.ExcerciseTypeId;
            subscription.SubscriptionPeriodId = createSubscriptionDTO.SubscriptionPeriodId;

            subscription.StartDate = createSubscriptionDTO.StartDate;
            subscription.EndDate = createSubscriptionDTO.EndDate;



            _subscriptionService.Add(subscription);
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public ActionResult UpdateSubscription(UpdateSubscriptionDTO updateSubscriptionDTO)
        {
            var existingSubscription = _subscriptionService.GetById(updateSubscriptionDTO.SubscriptionId);
            if (existingSubscription == null)
                return NotFound();

            existingSubscription.MemberId = updateSubscriptionDTO.MemberId;
            existingSubscription.PeriodId = updateSubscriptionDTO.PeriodId;
            existingSubscription.CoachId = updateSubscriptionDTO.CoachId;
            existingSubscription.CreatedByReceptionistId = updateSubscriptionDTO.CreatedByReceptionistId;
            existingSubscription.ExcerciseTypeId = updateSubscriptionDTO.ExcerciseTypeId;
            existingSubscription.SubscriptionPeriodId = updateSubscriptionDTO.SubscriptionPeriodId;

            existingSubscription.StartDate = updateSubscriptionDTO.StartDate;
            existingSubscription.EndDate = updateSubscriptionDTO.EndDate;


            _subscriptionService.Update(existingSubscription);
            return Ok();
        }


        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<ReadSubscriptionDTO>> Get()
        {

            var subscriptions = _subscriptionService.GetAll().Select(subscription => subscription.AsDTO());

            return Ok(subscriptions);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReadSubscriptionDTO> GetById(int id)
        {
            Subscription subscription = _subscriptionService.GetById(id);
            return subscription is null ? NotFound() : Ok(subscription.AsDTO());
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            Subscription subscription = _subscriptionService.GetById(id);

            if (subscription is null)
                return NotFound();

            _subscriptionService.DeleteById(subscription.SubscriptionId);

            return Ok();
        }
    }
}
