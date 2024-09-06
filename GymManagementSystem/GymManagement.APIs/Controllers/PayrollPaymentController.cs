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
    [Authorize(Roles = clsSystemRoles.Admin)]
    public class PayrollPaymentController : ControllerBase
    {
        private readonly IBaseServices<PayrollPayment> _payrollPaymentService;


        public PayrollPaymentController(IBaseServices<PayrollPayment> payrollPaymentService)
        {
            _payrollPaymentService = payrollPaymentService;
           
        }


        [HttpPost]
        [Route("")]

        public ActionResult CreatePayrollPayment(CreatePayrollPaymentDTO createPayrollPaymentDTO)
        {
            var payrollPayment = new PayrollPayment();

            payrollPayment.EmployeeId = createPayrollPaymentDTO.EmployeeId;
            

            _payrollPaymentService.Add(payrollPayment);
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public ActionResult UpdatePayrollPayment(UpdatePayrollPaymentDTO updatePayrollPaymentDTO)
        {
            var existingPayrollPayment = _payrollPaymentService.GetById(updatePayrollPaymentDTO.PaymentId);
            if (existingPayrollPayment == null)
                return NotFound();

            existingPayrollPayment.EmployeeId = updatePayrollPaymentDTO.EmployeeId;

            _payrollPaymentService.Update(existingPayrollPayment);
            return Ok();
        }


        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<ReadPayrollPaymentDTO>> Get()
        {

            var payrollPayments = _payrollPaymentService.GetAll().Select(payrollPayment => payrollPayment.AsDTO());

            return Ok(payrollPayments);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReadPayrollPaymentDTO> GetById(int id)
        {
            PayrollPayment payrollPayment = _payrollPaymentService.GetById(id);
            return payrollPayment is null ? NotFound() : Ok(payrollPayment.AsDTO());
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            PayrollPayment payrollPayment = _payrollPaymentService.GetById(id);

            if (payrollPayment is null)
                return NotFound();

            _payrollPaymentService.DeleteById(payrollPayment.PaymentId);

            return Ok();
        }
    }
}
