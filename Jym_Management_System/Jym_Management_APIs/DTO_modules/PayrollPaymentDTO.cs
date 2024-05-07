using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadPayrollPaymentDTO
        (
              int PaymentId ,
              DateTime PaymentDate,

              ReadEmployeeDTO Employee

        );

    public record CreatePayrollPaymentDTO
       (
             [Required]
             int EmployeeId
             

       );

    public record UpdatePayrollPaymentDTO
      (
            [Required]
            int PaymentId,
            [Required]
            int EmployeeId
          

      );
}
