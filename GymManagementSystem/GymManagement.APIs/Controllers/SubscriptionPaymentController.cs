using GymManagement.APIs.DTOs;
using GymManagement.BusinessCore.Models;
using Microsoft.AspNetCore.Mvc;
using GymManagement.BusinessCore.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using GymManagement.APIs.Authentication;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = (clsSystemRoles.User+","+clsSystemRoles.Admin))]
    public class SubscriptionPaymentController : ControllerBase
    {
        private readonly IBaseServices<SubscriptionPayment> _subscriptionPaymentService;


        public SubscriptionPaymentController(IBaseServices<SubscriptionPayment> subscriptionPaymentService)
        {
            _subscriptionPaymentService = subscriptionPaymentService;
           
        }


        [HttpPost]
        [Route("")]

        public ActionResult CreateSubscriptionPayment(CreateSubscriptionPaymentDTO createSubscriptionPaymentDTO)
        {
            var subscriptionPayment = new SubscriptionPayment();

            subscriptionPayment.PaymentAmount = createSubscriptionPaymentDTO.PaymentAmount;
            subscriptionPayment.CreatedByUserId = createSubscriptionPaymentDTO.CreatedByUserId;
            subscriptionPayment.SubscriptionId = createSubscriptionPaymentDTO.SubscriptionId;

            _subscriptionPaymentService.Add(subscriptionPayment);
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public ActionResult UpdateSubscriptionPayment(UpdateSubscriptionPaymentDTO updateSubscriptionPaymentDTO)
        {
            var existingSubscriptionPayment = _subscriptionPaymentService.GetById(updateSubscriptionPaymentDTO.PaymentId);
            if (existingSubscriptionPayment == null)
                return NotFound();

            existingSubscriptionPayment.PaymentAmount = updateSubscriptionPaymentDTO.PaymentAmount;
            existingSubscriptionPayment.CreatedByUserId = updateSubscriptionPaymentDTO.CreatedByUserId;
            existingSubscriptionPayment.SubscriptionId = updateSubscriptionPaymentDTO.SubscriptionId;

            _subscriptionPaymentService.Update(existingSubscriptionPayment);
            return Ok();
        }


        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<ReadSubscriptionPaymentDTO>> Get()
        {

            var subscriptionPayments = _subscriptionPaymentService.GetAll().Select(subscriptionPayments => subscriptionPayments.AsDTO());

            return Ok(subscriptionPayments);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReadSubscriptionPaymentDTO> GetById(int id)
        {
            SubscriptionPayment subscriptionPayment = _subscriptionPaymentService.GetById(id);
            return subscriptionPayment is null ? NotFound() : Ok(subscriptionPayment.AsDTO());
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            SubscriptionPayment subscriptionPayment = _subscriptionPaymentService.GetById(id);

            if (subscriptionPayment is null)
                return NotFound();

            _subscriptionPaymentService.DeleteById(subscriptionPayment.PaymentId.Value);

            return Ok();
        }
    }
}
